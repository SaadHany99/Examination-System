using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace ITI_ExaminationSystem
{
    public partial class ExamPage : MaterialForm
    {
        ExaminationSystemContext db;
        Student std;
        Exam exam;
        private System.Windows.Forms.Timer timer1;
        private TimeSpan timeRemaining;
        private List<Question> trueFalseQuestions;
        private List<Question> multipleChoiceQuestions;
        private Dictionary<string, List<string>> questionChoicesDict;
        private int examDuration;
        private Dictionary<int, string> userAnswers;
        private int currentQuestionIndex = 0;

        public ExamPage(ExaminationSystemContext examinationSystemContext, Student student)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            crsName_txtBox.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            Timer.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            Question_Count.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);

            db = examinationSystemContext;
            std = student;
            userAnswers = new Dictionary<int, string>();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            LoadExamDuration();
            timeRemaining = TimeSpan.FromHours(examDuration);
            Timer.Text = timeRemaining.ToString(@"hh\:mm\:ss");

            trueFalseQuestions = new List<Question>();
            multipleChoiceQuestions = new List<Question>();
            questionChoicesDict = new Dictionary<string, List<string>>();
            HideAllQuestionCards();
            materialCard1.Visible = true;
            Question_Count.Text = (currentQuestionIndex + 1).ToString() + " / 10";

        }

        private void Exam_Load(object sender, EventArgs e)
        {

            var exams = db.Student_Exams.Where(sx => sx.Student_ID == std.Student_ID && sx.Student_Degree == null).ToList();

            var examId = exams.FirstOrDefault(e => e.exam.Start_Time <= DateTime.Now && DateTime.Now < e.exam.Start_Time.AddHours(e.exam.Exam_Duration).AddSeconds(5)).Exam_ID;

            exam = db.Exams.FirstOrDefault(e => e.Exam_ID == examId);

            LoadQuestions();
            LoadQuestionChoices();

            crsName_txtBox.Text = GetCourseNameForExam(db);
            SetQuestionTexts();
            SetChoiceTexts();

            DateTime startTime = exam.Start_Time;
            int examDurationHours = exam.Exam_Duration;

            TimeSpan timeUntilStart = startTime - DateTime.Now;
            TimeSpan examDuration = TimeSpan.FromHours(examDurationHours);
            DateTime endTime = startTime.Add(examDuration);

            // Exam is ongoing
            timeRemaining = examDuration - (DateTime.Now - startTime);

            if (timeRemaining < TimeSpan.Zero)
            {
                timeRemaining = TimeSpan.Zero;
            }

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1));
            if (timeRemaining.TotalSeconds >= 0)
            {
                Timer.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                timeRemaining = TimeSpan.Zero;
                Timer.Text = timeRemaining.ToString(@"mm\:ss");

                GatherUserAnswers();
                SaveUserAnswersToDatabase();

                this.Hide();
                StudentProfile studentProfile = new StudentProfile(db, std);
                studentProfile.FormClosed += (obj, args) => this.Close();
                studentProfile.Show();
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            GatherUserAnswers();
            if (userAnswers.Count == 10)
            {
                SaveUserAnswersToDatabase();
                timer1.Stop();
                timeRemaining = TimeSpan.Zero;
                Timer.Text = timeRemaining.ToString(@"mm\:ss");


                this.Hide();
                StudentProfile studentProfile = new StudentProfile(db, std);
                studentProfile.FormClosed += (obj, args) => this.Close();
                studentProfile.Show();
            }
            else
            {
                MessageBox.Show("Please answer all questions before submitting the exam.", "Unanswered Questions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userAnswers.Clear();
            }
        }

        //private bool AnyUnansweredQuestions()
        //{
        //    // Check true/false questions
        //    foreach (var radioButton in Controls.OfType<RadioButton>())
        //    {
        //        if (radioButton.Checked && radioButton.Name.StartsWith("question"))
        //            return false; // At least one question is answered
        //    }

        //    // Check multiple choice questions
        //    foreach (var checkBox in Controls.OfType<CheckBox>())
        //    {
        //        if (checkBox.Checked && checkBox.Name.StartsWith("question"))
        //            return false; // At least one question is answered
        //    }

        //    // If no answered questions found
        //    return true;
        //}


        private void GatherUserAnswers()
        {
            var trueFalseRadioButtons = new[]
            {
                new[] { question1_TFT, question1_TFF },
                new[] { question2_TFT, question2_TFF },
                new[] { question3_TFT, question3_TFF }
            };

            for (int i = 0; i < trueFalseQuestions.Count; i++)
            {
                string selectedAnswer = null;

                foreach (var radioButton in trueFalseRadioButtons[i])
                {
                    if (radioButton.Checked)
                    {
                        selectedAnswer = radioButton.Text;
                        break;
                    }
                }

                if (selectedAnswer != null)
                {
                    userAnswers.Add(trueFalseQuestions[i].Question_ID, selectedAnswer);
                }
                //else
                //{
                //    userAnswers.Add(trueFalseQuestions[i].Question_ID, "Unanswered");
                //}
            }

            for (int i = 0; i < multipleChoiceQuestions.Count; i++)
            {
                string selectedChoice = null;
                var choiceLabels = new[]
                {
                    new[] { question4_CِA, question4_CB, question4_CC, question4_CD },
                    new[] { question5_CA, question5_CB, question5_CC, question5_CD },
                    new[] { question6_CA, question6_CB, question6_CC, question6_CD },
                    new[] { question7_CA, question7_CB, question7_CC, question7_CD },
                    new[] { question8_CA, question8_CB, question8_CC, question8_CD },
                    new[] { question9_CA, question9_CB, question9_CC, question9_CD },
                    new[] { question10_CA, question10_CB, question10_CC, question10_CD }
                };

                for (int j = 0; j < choiceLabels[i].Length; j++)
                {
                    if (choiceLabels[i][j].Checked)
                    {
                        selectedChoice = choiceLabels[i][j].Text;
                        break;
                    }
                }

                if (selectedChoice != null)
                {
                    userAnswers.Add(multipleChoiceQuestions[i].Question_ID, selectedChoice);
                }
                //else
                //{
                //    userAnswers.Add(multipleChoiceQuestions[i].Question_ID, "Unanswered");
                //}
            }
        }



        private string GetCourseNameForExam(ExaminationSystemContext db)
        {
            if (exam != null)
            {
                var course = db.Courses.FirstOrDefault(c => c.Course_ID == exam.Course_ID);

                if (course != null)
                {
                    return course.Course_Name;
                }
                else
                {
                    return "Course Not Found";
                }
            }
            else
            {
                return "Exam Not Found";
            }
        }
        private void LoadQuestions()
        {
            if (exam != null)
            {

                multipleChoiceQuestions = db.Exam_Questions
                    .Where(q => q.question.Question_Type == 'M' && q.Exam_ID == exam.Exam_ID).Select(q => q.question)
                    .ToList();

                trueFalseQuestions = db.Exam_Questions
                    .Where(q => q.question.Question_Type == 'T' && q.Exam_ID == exam.Exam_ID).Select(q => q.question)
                    .ToList();
            }
        }
        private void LoadQuestionChoices()
        {
            foreach (var question in multipleChoiceQuestions)
            {
                var choices = db.Question_Choices
                    .Where(q => q.Question_ID == question.Question_ID)
                    .Select(q => q.Choice)
                    .ToList();

                questionChoicesDict.Add(question.Question_Header, choices); // Add question and its choices to the dictionary
            }
        }
        private void LoadExamDuration()
        {
            if (exam != null)
            {
                examDuration = exam.Exam_Duration;
            }
            else
            {
                examDuration = 1;
            }
        }
        private void SetQuestionTexts()
        {
            var tfQuestions = new[] { question1_TF, question2_TF, question3_TF };
            var mcQuestions = new[] { question4_M, question5_M, question6_M, question7_M, question8_M, question9_M, question10_M };

            for (int i = 0; i < trueFalseQuestions.Count; i++)
            {
                tfQuestions[i].Text = trueFalseQuestions[i].Question_Header;
            }

            for (int i = 0; i < multipleChoiceQuestions.Count; i++)
            {
                mcQuestions[i].Text = multipleChoiceQuestions[i].Question_Header;
            }
        }
        private void SetChoiceTexts()
        {
            var choiceLabels = new[]
            {
                new[] { question4_CِA, question4_CB, question4_CC, question4_CD },
                new[] { question5_CA, question5_CB, question5_CC, question5_CD },
                new[] { question6_CA, question6_CB, question6_CC, question6_CD },
                new[] { question7_CA, question7_CB, question7_CC, question7_CD },
                new[] { question8_CA, question8_CB, question8_CC, question8_CD },
                new[] { question9_CA, question9_CB, question9_CC, question9_CD },
                new[] { question10_CA, question10_CB, question10_CC, question10_CD }
            };

            for (int i = 0; i < multipleChoiceQuestions.Count; i++)
            {
                var choices = questionChoicesDict[multipleChoiceQuestions[i].Question_Header];
                for (int j = 0; j < choices.Count; j++)
                {
                    choiceLabels[i][j].Text = choices[j];
                }
            }
        }
        private void SaveUserAnswersToDatabase()
        {
            var examIdParam = new SqlParameter("@exam_id", exam.Exam_ID);
            var studentIdParam = new SqlParameter("@student_id", std.Student_ID);

            var questionAndAnswerParams = new List<SqlParameter>();

            foreach (var userAnswer in userAnswers)
            {
                var questionParamName = $"@q{userAnswer.Key}";
                var answerParamName = $"@a{userAnswer.Key}";

                questionAndAnswerParams.Add(new SqlParameter(questionParamName, userAnswer.Key));
                questionAndAnswerParams.Add(new SqlParameter(answerParamName, userAnswer.Value));
            }

            var allParams = new List<SqlParameter> { examIdParam, studentIdParam };
            allParams.AddRange(questionAndAnswerParams);

            db.Database.ExecuteSqlRaw("EXEC Store_Student_Answers @exam_id, @student_id, " +
                                       string.Join(", ", questionAndAnswerParams.Select(p => p.ParameterName)),
                                       allParams.ToArray());

            db.Database.ExecuteSqlRaw($"EXEC Correct_Exam {exam.Exam_ID}, {std.Student_ID}");
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < (multipleChoiceQuestions.Count + trueFalseQuestions.Count - 1))
            {
                currentQuestionIndex++;
                ShowCurrentQuestion();
                Prev_btn.Visible = true;
                Next_btn.Visible = true;
                Question_Count.Text = (currentQuestionIndex + 1).ToString() + " / 10";

                if (currentQuestionIndex == (multipleChoiceQuestions.Count + trueFalseQuestions.Count - 1))
                {
                    submit_btn.Visible = true;
                    Next_btn.Visible = false;
                }
            }
        }


        private void Prev_btn_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                Question_Count.Text = currentQuestionIndex.ToString() + " / 10";
                currentQuestionIndex--;
                ShowCurrentQuestion();
                Next_btn.Visible = true;
                Prev_btn.Visible = (currentQuestionIndex > 0);
            }
        }


        private void ShowCurrentQuestion()
        {
            HideAllQuestionCards();
            int index = 0;
            foreach (var questionCard in GetAllQuestionCards())
            {
                if (index == currentQuestionIndex)
                {
                    questionCard.Visible = true;
                    break;
                }
                index++;
            }
        }

        private void HideAllQuestionCards()
        {
            foreach (var questionCard in GetAllQuestionCards())
            {
                questionCard.Visible = false;
            }
        }

        private IEnumerable<MaterialCard> GetAllQuestionCards()
        {
            yield return materialCard1;
            yield return materialCard2;
            yield return materialCard3;
            yield return materialCard4;
            yield return materialCard5;
            yield return materialCard6;
            yield return materialCard7;
            yield return materialCard8;
            yield return materialCard10;
            yield return materialCard9;
        }
    }
}
