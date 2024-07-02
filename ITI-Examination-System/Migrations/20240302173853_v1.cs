using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Branch_Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_ID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Topic_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Topic_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Track_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Track_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Track_ID);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Account_Type = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Branch_Tracks",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false),
                    Track_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_Tracks", x => new { x.Branch_ID, x.Track_ID });
                    table.ForeignKey(
                        name: "FK_Branch_Tracks_Branches_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "Branches",
                        principalColumn: "Branch_ID");
                    table.ForeignKey(
                        name: "FK_Branch_Tracks_Tracks_Track_ID",
                        column: x => x.Track_ID,
                        principalTable: "Tracks",
                        principalColumn: "Track_ID");
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Instructor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instructor_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Instructor_Salary = table.Column<decimal>(type: "money", nullable: false),
                    Instructor_Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Instructor_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Instructor_ID);
                    table.ForeignKey(
                        name: "FK_Instructors_Branches_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "Branches",
                        principalColumn: "Branch_ID");
                    table.ForeignKey(
                        name: "FK_Instructors_UserAccounts_User_ID",
                        column: x => x.User_ID,
                        principalTable: "UserAccounts",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Student_Age = table.Column<int>(type: "int", nullable: false),
                    Student_Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Student_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Branch_ID = table.Column<int>(type: "int", nullable: false),
                    Track_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_ID);
                    table.ForeignKey(
                        name: "FK_Students_Branches_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "Branches",
                        principalColumn: "Branch_ID");
                    table.ForeignKey(
                        name: "FK_Students_Tracks_Track_ID",
                        column: x => x.Track_ID,
                        principalTable: "Tracks",
                        principalColumn: "Track_ID");
                    table.ForeignKey(
                        name: "FK_Students_UserAccounts_User_ID",
                        column: x => x.User_ID,
                        principalTable: "UserAccounts",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Course_Duration = table.Column<int>(type: "int", nullable: false),
                    Instructor_ID = table.Column<int>(type: "int", nullable: false),
                    Topic_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_ID);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_Instructor_ID",
                        column: x => x.Instructor_ID,
                        principalTable: "Instructors",
                        principalColumn: "Instructor_ID");
                    table.ForeignKey(
                        name: "FK_Courses_Topics_Topic_ID",
                        column: x => x.Topic_ID,
                        principalTable: "Topics",
                        principalColumn: "Topic_ID");
                });

            migrationBuilder.CreateTable(
                name: "Instructor_Tracks",
                columns: table => new
                {
                    InstructorTrack_ID = table.Column<int>(type: "int", nullable: false),
                    Track_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Tracks", x => new { x.InstructorTrack_ID, x.Track_ID });
                    table.ForeignKey(
                        name: "FK_Instructor_Tracks_Instructors_InstructorTrack_ID",
                        column: x => x.InstructorTrack_ID,
                        principalTable: "Instructors",
                        principalColumn: "Instructor_ID");
                    table.ForeignKey(
                        name: "FK_Instructor_Tracks_Tracks_Track_ID",
                        column: x => x.Track_ID,
                        principalTable: "Tracks",
                        principalColumn: "Track_ID");
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Exam_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exam_Duration = table.Column<int>(type: "int", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Instructor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Exam_ID);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID");
                    table.ForeignKey(
                        name: "FK_Exams_Instructors_Instructor_ID",
                        column: x => x.Instructor_ID,
                        principalTable: "Instructors",
                        principalColumn: "Instructor_ID");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Question_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question_Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question_Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Model_Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Instructor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Question_ID);
                    table.ForeignKey(
                        name: "FK_Questions_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID");
                    table.ForeignKey(
                        name: "FK_Questions_Instructors_Instructor_ID",
                        column: x => x.Instructor_ID,
                        principalTable: "Instructors",
                        principalColumn: "Instructor_ID");
                });

            migrationBuilder.CreateTable(
                name: "Track_Courses",
                columns: table => new
                {
                    Track_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track_Courses", x => new { x.Track_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Track_Courses_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID");
                    table.ForeignKey(
                        name: "FK_Track_Courses_Tracks_Track_ID",
                        column: x => x.Track_ID,
                        principalTable: "Tracks",
                        principalColumn: "Track_ID");
                });

            migrationBuilder.CreateTable(
                name: "Student_Exams",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Exam_ID = table.Column<int>(type: "int", nullable: false),
                    Student_Degree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Exams", x => new { x.Student_ID, x.Exam_ID });
                    table.ForeignKey(
                        name: "FK_Student_Exams_Exams_Exam_ID",
                        column: x => x.Exam_ID,
                        principalTable: "Exams",
                        principalColumn: "Exam_ID");
                    table.ForeignKey(
                        name: "FK_Student_Exams_Students_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID");
                });

            migrationBuilder.CreateTable(
                name: "Exam_Questions",
                columns: table => new
                {
                    Exam_ID = table.Column<int>(type: "int", nullable: false),
                    Question_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Questions", x => new { x.Exam_ID, x.Question_ID });
                    table.ForeignKey(
                        name: "FK_Exam_Questions_Exams_Exam_ID",
                        column: x => x.Exam_ID,
                        principalTable: "Exams",
                        principalColumn: "Exam_ID");
                    table.ForeignKey(
                        name: "FK_Exam_Questions_Questions_Question_ID",
                        column: x => x.Question_ID,
                        principalTable: "Questions",
                        principalColumn: "Question_ID");
                });

            migrationBuilder.CreateTable(
                name: "Question_Choices",
                columns: table => new
                {
                    Question_ID = table.Column<int>(type: "int", nullable: false),
                    Choice_ID = table.Column<int>(type: "int", nullable: false),
                    Choice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question_Choices", x => new { x.Question_ID, x.Choice_ID });
                    table.ForeignKey(
                        name: "FK_Question_Choices_Questions_Question_ID",
                        column: x => x.Question_ID,
                        principalTable: "Questions",
                        principalColumn: "Question_ID");
                });

            migrationBuilder.CreateTable(
                name: "Student_Answers",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Exam_ID = table.Column<int>(type: "int", nullable: false),
                    Question_ID = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Answers", x => new { x.Student_ID, x.Exam_ID, x.Question_ID });
                    table.ForeignKey(
                        name: "FK_Student_Answers_Exams_Exam_ID",
                        column: x => x.Exam_ID,
                        principalTable: "Exams",
                        principalColumn: "Exam_ID");
                    table.ForeignKey(
                        name: "FK_Student_Answers_Questions_Question_ID",
                        column: x => x.Question_ID,
                        principalTable: "Questions",
                        principalColumn: "Question_ID");
                    table.ForeignKey(
                        name: "FK_Student_Answers_Students_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "Students",
                        principalColumn: "Student_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_Tracks_Track_ID",
                table: "Branch_Tracks",
                column: "Track_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Instructor_ID",
                table: "Courses",
                column: "Instructor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Topic_ID",
                table: "Courses",
                column: "Topic_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Questions_Question_ID",
                table: "Exam_Questions",
                column: "Question_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_Course_ID",
                table: "Exams",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_Instructor_ID",
                table: "Exams",
                column: "Instructor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Tracks_Track_ID",
                table: "Instructor_Tracks",
                column: "Track_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Branch_ID",
                table: "Instructors",
                column: "Branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_User_ID",
                table: "Instructors",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Course_ID",
                table: "Questions",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Instructor_ID",
                table: "Questions",
                column: "Instructor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Answers_Exam_ID",
                table: "Student_Answers",
                column: "Exam_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Answers_Question_ID",
                table: "Student_Answers",
                column: "Question_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exams_Exam_ID",
                table: "Student_Exams",
                column: "Exam_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Branch_ID",
                table: "Students",
                column: "Branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Track_ID",
                table: "Students",
                column: "Track_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_User_ID",
                table: "Students",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Track_Courses_Course_ID",
                table: "Track_Courses",
                column: "Course_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch_Tracks");

            migrationBuilder.DropTable(
                name: "Exam_Questions");

            migrationBuilder.DropTable(
                name: "Instructor_Tracks");

            migrationBuilder.DropTable(
                name: "Question_Choices");

            migrationBuilder.DropTable(
                name: "Student_Answers");

            migrationBuilder.DropTable(
                name: "Student_Exams");

            migrationBuilder.DropTable(
                name: "Track_Courses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
