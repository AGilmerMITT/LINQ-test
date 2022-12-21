using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    public class Institute
    {
        public string Name { get; set; }
        public HashSet<Teacher> Teachers { get; set; } = new();
        public HashSet<Course> Courses { get; set; } = new();
        public HashSet<Student> Students { get; set; } = new();
        public HashSet<Classroom> Classrooms { get; set; } = new();
        public HashSet<ClassroomStudent> ClassroomStudents { get; set; } = new();


        public Institute(string name = "Hope's Peak Academy")
        {
            Name = name;
            InitializeData();
        }

        private void InitializeData()
        {
            #region Courses
            Course math = new(name: "Math", credits: 3);
            Course bio = new(name: "Biology", credits: 3);
            Course chem = new(name: "Chemistry", credits: 3);
            Course physics = new(name: "Physics", credits: 3);
            Course gym = new(name: "Phys Ed", credits: 2);
            Course compSci = new(name: "Computer Science", credits: 3);
            Course engLit = new(name: "English Literature", credits: 4);
            Course french = new(name: "French", credits: 1, minimumPassingGrade: 40);
            Course japanese = new(name: "Japanese", credits: 1, minimumPassingGrade: 40);
            Course spanish = new(name: "Spanish", credits: 1, minimumPassingGrade: 40);
            Course civics = new(name: "Civics", credits: 2);
            Course philo = new(name: "Philosophy", credits: 2, minimumPassingGrade: 40);
            Course engi = new(name: "Engineering", credits: 5, minimumPassingGrade: 75);

            Courses = new() { math, bio, chem, physics, gym, compSci, engLit, french, japanese, spanish, civics, philo, engi };
            #endregion Courses

            #region Teachers
            Teacher t1 = new("Jamie Proctor");
            Teacher t2 = new("Dewey Weaver");
            Teacher t3 = new("Elbert Cabrera");
            Teacher t4 = new("Dianne Page");
            Teacher t5 = new("Eddy Travis");
            Teacher t6 = new("German Huff");
            Teacher t7 = new("Sherrie Mclaughlin");
            Teacher t8 = new("Shanna Harrington");
            Teacher t9 = new("Lacy Hansen");
            Teacher t10 = new("Pearl Morris");
            Teacher t11 = new("Antonia Jennings");
            Teacher t12 = new("Abram Deleon");
            Teacher t13 = new("Ethel Frey");
            Teacher t14 = new("Briana Kemp");
            Teacher t15 = new("Tracy Pham");
            Teacher t16 = new("Patty Garcia");
            Teacher t17 = new("Bertie Brewer");
            Teacher t18 = new("Brian Khan");
            Teacher t19 = new("Francesco Gallegos");
            Teacher t20 = new("Dwayne Mays");
            Teacher t21 = new("Maureen Gross");
            Teacher t22 = new("Herminia Bonilla");
            Teacher t23 = new("Genevieve Duarte");
            Teacher t24 = new("Bernice Riggs");
            Teacher t25 = new("Russ Berry");

            Teachers = new() { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25 };
            #endregion Teachers

            #region Classrooms
            Classroom math10 = MakeClassroom(math, t1);
            Classroom math11 = MakeClassroom(math, t2);
            Classroom math12 = MakeClassroom(math, t3);

            Classroom bio10 = MakeClassroom(bio, t4);
            Classroom bio11 = MakeClassroom(bio, t5);
            Classroom bio12 = MakeClassroom(bio, t6);

            Classroom chem10 = MakeClassroom(chem, t3);
            Classroom chem11 = MakeClassroom(chem, t7);
            Classroom chem12 = MakeClassroom(chem, t3);

            Classroom phys10 = MakeClassroom(physics, t14);
            Classroom phys11 = MakeClassroom(physics, t8);
            Classroom phys12 = MakeClassroom(physics, t8);

            Classroom gym10 = MakeClassroom(gym, t9);
            Classroom gym11 = MakeClassroom(gym, t9);
            Classroom gym12 = MakeClassroom(gym, t10);

            Classroom comp10 = MakeClassroom(compSci, t11);
            Classroom comp11 = MakeClassroom(compSci, t12);
            Classroom comp12 = MakeClassroom(compSci, t13);

            Classroom eng10 = MakeClassroom(engLit, t14);
            Classroom eng11 = MakeClassroom(engLit, t15);
            Classroom eng12 = MakeClassroom(engLit, t16);

            Classroom fr10 = MakeClassroom(french, t17);
            Classroom fr11 = MakeClassroom(french, t17);
            Classroom fr12 = MakeClassroom(french, t17);

            Classroom jp10 = MakeClassroom(japanese, t18);
            Classroom jp11 = MakeClassroom(japanese, t19);
            Classroom jp12 = MakeClassroom(japanese, t19);

            Classroom esp10 = MakeClassroom(spanish, t20);
            Classroom esp11 = MakeClassroom(spanish, t21);
            Classroom esp12 = MakeClassroom(spanish, t22);

            Classroom civ10 = MakeClassroom(civics, t23);
            Classroom civ11 = MakeClassroom(civics, t24);
            Classroom civ12 = MakeClassroom(civics, t25);

            Classroom phi10 = MakeClassroom(philo, t23);
            Classroom phi11 = MakeClassroom(philo, t24);
            Classroom phi12 = MakeClassroom(philo, t17);

            Classroom engi10 = MakeClassroom(engi, t16);
            Classroom engi11 = MakeClassroom(engi, t22);
            Classroom engi12 = MakeClassroom(engi, t19);

            List<Classroom> grade10 = new() { math10, bio10, chem10, phys10, gym10, comp10, eng10, fr10, esp10, jp10, civ10, phi10, engi10 };
            List<Classroom> grade11 = new() { math11, bio11, chem11, phys11, gym11, comp11, eng11, fr11, esp11, jp11, civ11, phi11, engi11 };
            List<Classroom> grade12 = new() { math12, bio12, chem12, phys12, gym12, comp12, eng12, fr12, esp12, jp12, civ12, phi12, engi12 };
            #endregion Classrooms

            #region Students000-099
            Student s000 = MakeStudent("Alan", "Cunningham", "South Korea", 11,
                new Classroom[] { grade11[1], grade11[8] }, new int[] { 94, 87 });
            Student s001 = MakeStudent("Danny", "Stewart", "Spain", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[10] }, new int[] { 52, 70, 42 });
            Student s002 = MakeStudent("Shelly", "Hart", "England", 10,
                new Classroom[] { grade10[1], grade10[10] }, new int[] { 45, 46 });
            Student s003 = MakeStudent("Martha", "Lambert", "Russia", 11,
                new Classroom[] { grade11[6], grade11[11] }, new int[] { 51, 57 });
            Student s004 = MakeStudent("Edward", "Rice", "China", 12,
                new Classroom[] { grade12[8] }, new int[] { 62 });
            Student s005 = MakeStudent("Herminia", "Porter", "China", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[7], grade10[9] }, new int[] { 80, 49, 65, 89 });
            Student s006 = MakeStudent("Jeremiah", "Welch", "Japan", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[12] }, new int[] { 41, 66, 63 });
            Student s007 = MakeStudent("Amber", "Welch", "United States", 11,
                new Classroom[] { grade11[2], grade11[7] }, new int[] { 49, 89 });
            Student s008 = MakeStudent("Peter", "Soto", "South Korea", 12,
                new Classroom[] { grade12[5] }, new int[] { 78 });
            Student s009 = MakeStudent("Clyde", "George", "Egypt", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[5], grade11[6], grade11[11] }, new int[] { 51, 53, 88, 86, 58 });
            Student s010 = MakeStudent("Jessie", "Brewer", "Spain", 12,
                new Classroom[] { grade12[4], grade12[6], grade12[11], grade12[12] }, new int[] { 81, 99, 96, 79 });
            Student s011 = MakeStudent("Miguel", "Rhodes", "Canada", 11,
                new Classroom[] { grade11[0], grade11[3], grade11[7], grade11[10], grade11[11] }, new int[] { 95, 67, 99, 69, 93 });
            Student s012 = MakeStudent("Ray", "Terry", "Russia", 10,
                new Classroom[] { grade10[0], grade10[7] }, new int[] { 93, 88 });
            Student s013 = MakeStudent("Leona", "Hill", "Spain", 11,
                new Classroom[] { grade11[12] }, new int[] { 96 });
            Student s014 = MakeStudent("Minnie", "Burke", "Australia", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[10] }, new int[] { 50, 63, 75 });
            Student s015 = MakeStudent("Jessie", "Dunn", "Spain", 12,
                new Classroom[] { grade12[3], grade12[7] }, new int[] { 74, 69 });
            Student s016 = MakeStudent("Lily", "Duncan", "South Korea", 11,
                new Classroom[] { grade11[0], grade11[5] }, new int[] { 65, 46 });
            Student s017 = MakeStudent("Jane", "Mccoy", "Australia", 11,
                new Classroom[] { grade11[6], grade11[7] }, new int[] { 48, 78 });
            Student s018 = MakeStudent("Regina", "Hunter", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[3], grade12[8], grade12[12] }, new int[] { 83, 83, 88, 92 });
            Student s019 = MakeStudent("Tanya", "Kelly", "Greece", 11,
                new Classroom[] { grade11[7] }, new int[] { 81 });
            Student s020 = MakeStudent("Nina", "Berry", "Mexico", 10,
                new Classroom[] { grade10[1], grade10[3], grade10[6], grade10[7], grade10[8] }, new int[] { 58, 75, 77, 54, 57 });
            Student s021 = MakeStudent("Alfred", "Mitchelle", "Vietnam", 11,
                new Classroom[] { grade11[6] }, new int[] { 85 });
            Student s022 = MakeStudent("Elaine", "Harrison", "Canada", 11,
                new Classroom[] { grade11[3], grade11[6], grade11[7], grade11[12] }, new int[] { 99, 91, 60, 94 });
            Student s023 = MakeStudent("Emma", "Foster", "Spain", 12,
                new Classroom[] { grade12[4], grade12[6] }, new int[] { 55, 60 });
            Student s024 = MakeStudent("Gabriel", "Herrera", "United States", 10,
                new Classroom[] { grade10[5], grade10[6], grade10[7], grade10[8], grade10[12] }, new int[] { 89, 49, 63, 61, 90 });
            Student s025 = MakeStudent("Hector", "Romero", "China", 12,
                new Classroom[] { grade12[2], grade12[3], grade12[8] }, new int[] { 92, 63, 56 });
            Student s026 = MakeStudent("Felecia", "Roberts", "Mexico", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[8], grade11[11] }, new int[] { 98, 60, 40, 99 });
            Student s027 = MakeStudent("Marlene", "Reynolds", "China", 12,
                new Classroom[] { grade12[10] }, new int[] { 42 });
            Student s028 = MakeStudent("Debbie", "Rodriquez", "Canada", 10,
                new Classroom[] { grade10[6], grade10[8] }, new int[] { 94, 98 });
            Student s029 = MakeStudent("Janet", "Medina", "Nigeria", 12,
                new Classroom[] { grade12[1] }, new int[] { 95 });
            Student s030 = MakeStudent("Evan", "Bailey", "Iran", 11,
                new Classroom[] { grade11[4], grade11[7], grade11[12] }, new int[] { 66, 62, 69 });
            Student s031 = MakeStudent("Toni", "Caldwell", "Russia", 12,
                new Classroom[] { grade12[7] }, new int[] { 73 });
            Student s032 = MakeStudent("Hailey", "Clark", "Egypt", 12,
                new Classroom[] { grade12[4], grade12[7], grade12[8], grade12[10], grade12[11] }, new int[] { 89, 45, 86, 62, 73 });
            Student s033 = MakeStudent("Wesley", "Hanson", "South Korea", 11,
                new Classroom[] { grade11[1], grade11[2], grade11[5], grade11[7], grade11[10] }, new int[] { 52, 54, 78, 51, 99 });
            Student s034 = MakeStudent("Ethan", "Butler", "France", 12,
                new Classroom[] { grade12[0], grade12[11] }, new int[] { 78, 56 });
            Student s035 = MakeStudent("Lauren", "Burns", "China", 10,
                new Classroom[] { grade10[3], grade10[6] }, new int[] { 48, 100 });
            Student s036 = MakeStudent("Johnni", "Steeves ", "Egypt", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[7] }, new int[] { 60, 67, 94 });
            Student s037 = MakeStudent("Leroy", "Woods", "Greece", 12,
                new Classroom[] { grade12[0] }, new int[] { 71 });
            Student s038 = MakeStudent("Steve", "Armstrong", "England", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[5], grade12[10] }, new int[] { 84, 74, 97, 45 });
            Student s039 = MakeStudent("Aubrey", "Parker", "Turkey", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[4], grade12[6], grade12[10] }, new int[] { 44, 93, 90, 88, 44 });
            Student s040 = MakeStudent("Cameron", "Hudson", "Japan", 10,
                new Classroom[] { grade10[3], grade10[10] }, new int[] { 97, 65 });
            Student s041 = MakeStudent("Wallace", "Murray", "Egypt", 10,
                new Classroom[] { grade10[11] }, new int[] { 54 });
            Student s042 = MakeStudent("Tim", "Reed", "Turkey", 12,
                new Classroom[] { grade12[6] }, new int[] { 56 });
            Student s043 = MakeStudent("Aubrey", "Carroll", "Spain", 10,
                new Classroom[] { grade10[4], grade10[8] }, new int[] { 81, 74 });
            Student s044 = MakeStudent("Elijah", "Howard", "Vietnam", 10,
                new Classroom[] { grade10[3], grade10[8], grade10[12] }, new int[] { 51, 87, 57 });
            Student s045 = MakeStudent("Sophia", "Flores", "South Korea", 11,
                new Classroom[] { grade11[2], grade11[4], grade11[12] }, new int[] { 60, 67, 70 });
            Student s046 = MakeStudent("Mary", "Fernandez", "Egypt", 10,
                new Classroom[] { grade10[1] }, new int[] { 95 });
            Student s047 = MakeStudent("Lucy", "Ellis", "Mexico", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[7], grade10[8], grade10[10] }, new int[] { 53, 100, 49, 92, 54 });
            Student s048 = MakeStudent("Mario", "Clark", "South Korea", 11,
                new Classroom[] { grade11[5], grade11[11] }, new int[] { 95, 82 });
            Student s049 = MakeStudent("Rhonda", "Sims", "Russia", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[6] }, new int[] { 51, 46, 97 });
            Student s050 = MakeStudent("Elaine", "Richards", "Japan", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[6], grade12[10] }, new int[] { 75, 50, 80, 71 });
            Student s051 = MakeStudent("Joy", "Wood", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[5], grade12[7], grade12[8] }, new int[] { 45, 42, 85, 96, 86 });
            Student s052 = MakeStudent("Johnny", "Rice", "Greece", 12,
                new Classroom[] { grade12[4] }, new int[] { 79 });
            Student s053 = MakeStudent("Catherine", "Jensen", "United States", 12,
                new Classroom[] { grade12[2], grade12[6], grade12[7] }, new int[] { 46, 83, 45 });
            Student s054 = MakeStudent("Bertha", "Owens", "France", 11,
                new Classroom[] { grade11[0], grade11[4] }, new int[] { 98, 56 });
            Student s055 = MakeStudent("Jorge", "Curtis", "China", 11,
                new Classroom[] { grade11[11] }, new int[] { 59 });
            Student s056 = MakeStudent("Ashley", "Willis", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[5] }, new int[] { 58, 95 });
            Student s057 = MakeStudent("Clayton", "Rodriquez", "South Korea", 11,
                new Classroom[] { grade11[3], grade11[6], grade11[8], grade11[10] }, new int[] { 66, 78, 55, 40 });
            Student s058 = MakeStudent("Christian", "Cook", "Greece", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[7], grade12[8], grade12[11] }, new int[] { 46, 64, 65, 55, 72 });
            Student s059 = MakeStudent("Lewis", "George", "Japan", 12,
                new Classroom[] { grade12[2], grade12[6] }, new int[] { 55, 69 });
            Student s060 = MakeStudent("Becky", "Griffin", "Greece", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[5], grade10[6], grade10[9] }, new int[] { 54, 93, 80, 48, 56 });
            Student s061 = MakeStudent("Gina", "Lucas", "Japan", 11,
                new Classroom[] { grade11[4], grade11[6], grade11[9] }, new int[] { 47, 74, 85 });
            Student s062 = MakeStudent("Neil", "Gonzalez", "France", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[6], grade11[9] }, new int[] { 69, 40, 72, 66 });
            Student s063 = MakeStudent("Frances", "Duncan", "England", 12,
                new Classroom[] { grade12[4], grade12[8], grade12[11] }, new int[] { 63, 97, 43 });
            Student s064 = MakeStudent("Katrina", "Burton", "England", 10,
                new Classroom[] { grade10[2], grade10[3], grade10[10] }, new int[] { 83, 52, 75 });
            Student s065 = MakeStudent("Jacob", "Fields", "Nigeria", 12,
                new Classroom[] { grade12[7], grade12[10] }, new int[] { 84, 98 });
            Student s066 = MakeStudent("Alan", "Freeman", "South Korea", 11,
                new Classroom[] { grade11[7] }, new int[] { 49 });
            Student s067 = MakeStudent("Oscar", "Dunn", "South Korea", 11,
                new Classroom[] { grade11[0], grade11[6], grade11[9], grade11[10], grade11[11] }, new int[] { 88, 51, 74, 61, 74 });
            Student s068 = MakeStudent("Alexis", "Lane", "South Korea", 11,
                new Classroom[] { grade11[5], grade11[10], grade11[12] }, new int[] { 87, 89, 42 });
            Student s069 = MakeStudent("Colleen", "Craig", "United States", 11,
                new Classroom[] { grade11[1], grade11[5], grade11[9], grade11[11], grade11[12] }, new int[] { 58, 43, 83, 94, 69 });
            Student s070 = MakeStudent("Willie", "Hopkins", "Egypt", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[5], grade10[6], grade10[8] }, new int[] { 65, 100, 74, 54, 89 });
            Student s071 = MakeStudent("Sergio", "Taylor", "Nigeria", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[6] }, new int[] { 54, 69, 46 });
            Student s072 = MakeStudent("Dustin", "Carroll", "Australia", 10,
                new Classroom[] { grade10[5] }, new int[] { 59 });
            Student s073 = MakeStudent("Andre", "Hoffman", "China", 10,
                new Classroom[] { grade10[0], grade10[5] }, new int[] { 83, 63 });
            Student s074 = MakeStudent("June", "Allen", "Canada", 11,
                new Classroom[] { grade11[4] }, new int[] { 51 });
            Student s075 = MakeStudent("Nina", "Martin", "France", 10,
                new Classroom[] { grade10[2], grade10[6] }, new int[] { 98, 72 });
            Student s076 = MakeStudent("Pamela", "Davidson", "Turkey", 11,
                new Classroom[] { grade11[1], grade11[5], grade11[7] }, new int[] { 71, 83, 96 });
            Student s077 = MakeStudent("Celina", "Ruiz", "Iran", 12,
                new Classroom[] { grade12[0], grade12[10] }, new int[] { 79, 73 });
            Student s078 = MakeStudent("Tonya", "Richards", "Nigeria", 10,
                new Classroom[] { grade10[8] }, new int[] { 89 });
            Student s079 = MakeStudent("Charlie", "Medina", "United States", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[8], grade12[9], grade12[11] }, new int[] { 65, 100, 75, 82, 98 });
            Student s080 = MakeStudent("Ramon", "Ortiz", "England", 12,
                new Classroom[] { grade12[0], grade12[7], grade12[8] }, new int[] { 57, 57, 94 });
            Student s081 = MakeStudent("Mark", "Simmmons", "Egypt", 10,
                new Classroom[] { grade10[5] }, new int[] { 45 });
            Student s082 = MakeStudent("Jesus", "Foster", "Spain", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[10], grade11[12] }, new int[] { 89, 50, 67, 97 });
            Student s083 = MakeStudent("Catherine", "Miles", "Iran", 12,
                new Classroom[] { grade12[9] }, new int[] { 84 });
            Student s084 = MakeStudent("Tracy", "Payne", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[6], grade10[8], grade10[9] }, new int[] { 75, 48, 87, 45 });
            Student s085 = MakeStudent("Ellen", "Lowe", "Russia", 12,
                new Classroom[] { grade12[0], grade12[7] }, new int[] { 96, 71 });
            Student s086 = MakeStudent("Paula", "Rodriguez", "Spain", 12,
                new Classroom[] { grade12[11] }, new int[] { 90 });
            Student s087 = MakeStudent("Laurie", "Spencer", "Japan", 11,
                new Classroom[] { grade11[1] }, new int[] { 76 });
            Student s088 = MakeStudent("Kurt", "Watkins", "China", 10,
                new Classroom[] { grade10[8], grade10[9], grade10[12] }, new int[] { 97, 40, 98 });
            Student s089 = MakeStudent("Lucas", "Walters", "Russia", 12,
                new Classroom[] { grade12[0] }, new int[] { 73 });
            Student s090 = MakeStudent("June", "Herrera", "Australia", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[6] }, new int[] { 72, 62, 69 });
            Student s091 = MakeStudent("Grace", "Harrison", "Australia", 11,
                new Classroom[] { grade11[5], grade11[6] }, new int[] { 45, 44 });
            Student s092 = MakeStudent("Johnny", "George", "United States", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[8] }, new int[] { 76, 98, 83 });
            Student s093 = MakeStudent("Pearl", "Hill", "Egypt", 12,
                new Classroom[] { grade12[4], grade12[6], grade12[8], grade12[10], grade12[11] }, new int[] { 98, 78, 83, 66, 78 });
            Student s094 = MakeStudent("Jonathan", "Black", "United States", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[5], grade11[7], grade11[12] }, new int[] { 69, 41, 48, 91, 95 });
            Student s095 = MakeStudent("Michelle", "Morales", "Australia", 11,
                new Classroom[] { grade11[3], grade11[4], grade11[6], grade11[9], grade11[10] }, new int[] { 81, 78, 56, 82, 99 });
            Student s096 = MakeStudent("Veronica", "Martin", "Canada", 10,
                new Classroom[] { grade10[0], grade10[6], grade10[8] }, new int[] { 81, 47, 100 });
            Student s097 = MakeStudent("Ronald", "Spencer", "China", 12,
                new Classroom[] { grade12[9], grade12[10] }, new int[] { 75, 48 });
            Student s098 = MakeStudent("Erica", "Matthews", "China", 11,
                new Classroom[] { grade11[3], grade11[8], grade11[10], grade11[11], grade11[12] }, new int[] { 57, 58, 71, 46, 65 });
            Student s099 = MakeStudent("Ron", "Peters", "Canada", 12,
                new Classroom[] { grade12[11] }, new int[] { 50 });
            #endregion Students000-099

            #region Students100-199
            Student s100 = MakeStudent("Diana", "Rogers", "Vietnam", 12,
                new Classroom[] { grade12[6] }, new int[] { 54 });
            Student s101 = MakeStudent("Glen", "Fowler", "United States", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[5], grade10[6], grade10[10] }, new int[] { 44, 97, 95, 65, 50 });
            Student s102 = MakeStudent("Douglas", "Larson", "Nigeria", 12,
                new Classroom[] { grade12[2] }, new int[] { 66 });
            Student s103 = MakeStudent("Hazel", "Cole", "Egypt", 10,
                new Classroom[] { grade10[11] }, new int[] { 56 });
            Student s104 = MakeStudent("George", "Ramos", "Australia", 10,
                new Classroom[] { grade10[2], grade10[3], grade10[5], grade10[10], grade10[12] }, new int[] { 54, 71, 89, 40, 61 });
            Student s105 = MakeStudent("Clifford", "Simmmons", "South Korea", 10,
                new Classroom[] { grade10[3], grade10[4], grade10[6] }, new int[] { 85, 64, 80 });
            Student s106 = MakeStudent("Devon", "Johnson", "France", 11,
                new Classroom[] { grade11[0], grade11[5], grade11[6], grade11[9], grade11[11] }, new int[] { 98, 48, 81, 44, 60 });
            Student s107 = MakeStudent("Danny", "Rogers", "Iran", 12,
                new Classroom[] { grade12[2] }, new int[] { 87 });
            Student s108 = MakeStudent("Dustin", "Spencer", "South Korea", 10,
                new Classroom[] { grade10[7] }, new int[] { 74 });
            Student s109 = MakeStudent("Bobby", "Jones", "England", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[12] }, new int[] { 96, 91, 58 });
            Student s110 = MakeStudent("Brandy", "King", "Australia", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[2], grade10[6], grade10[10] }, new int[] { 92, 70, 75, 65, 73 });
            Student s111 = MakeStudent("Vicki", "Rice", "Vietnam", 10,
                new Classroom[] { grade10[2], grade10[5] }, new int[] { 54, 48 });
            Student s112 = MakeStudent("William", "Nguyen", "Australia", 10,
                new Classroom[] { grade10[3], grade10[4], grade10[7], grade10[10] }, new int[] { 56, 79, 85, 46 });
            Student s113 = MakeStudent("Freddie", "Hamilton", "China", 10,
                new Classroom[] { grade10[6] }, new int[] { 80 });
            Student s114 = MakeStudent("Joyce", "Robertson", "Nigeria", 10,
                new Classroom[] { grade10[5] }, new int[] { 93 });
            Student s115 = MakeStudent("Jimmie", "Nelson", "England", 12,
                new Classroom[] { grade12[8] }, new int[] { 43 });
            Student s116 = MakeStudent("Jean", "Hudson", "France", 10,
                new Classroom[] { grade10[7] }, new int[] { 60 });
            Student s117 = MakeStudent("Lonnie", "Rivera", "Vietnam", 10,
                new Classroom[] { grade10[7], grade10[9] }, new int[] { 66, 79 });
            Student s118 = MakeStudent("Maureen", "Torres", "China", 11,
                new Classroom[] { grade11[4], grade11[7] }, new int[] { 53, 93 });
            Student s119 = MakeStudent("Lance", "Coleman", "Nigeria", 10,
                new Classroom[] { grade10[3], grade10[5], grade10[6], grade10[7] }, new int[] { 58, 65, 84, 77 });
            Student s120 = MakeStudent("Clara", "Larson", "Iran", 10,
                new Classroom[] { grade10[9] }, new int[] { 48 });
            Student s121 = MakeStudent("Maureen", "Lucas", "England", 12,
                new Classroom[] { grade12[6] }, new int[] { 59 });
            Student s122 = MakeStudent("Louise", "Ford", "Vietnam", 10,
                new Classroom[] { grade10[1] }, new int[] { 48 });
            Student s123 = MakeStudent("Jeanne", "Burns", "Spain", 11,
                new Classroom[] { grade11[1], grade11[7], grade11[12] }, new int[] { 91, 66, 91 });
            Student s124 = MakeStudent("Juanita", "Lynch", "Australia", 12,
                new Classroom[] { grade12[2], grade12[4], grade12[9], grade12[10] }, new int[] { 56, 97, 44, 71 });
            Student s125 = MakeStudent("Lynn", "Hopkins", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[3], grade11[5], grade11[7], grade11[10] }, new int[] { 42, 56, 82, 70, 78 });
            Student s126 = MakeStudent("Clarence", "Reed", "Japan", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[8], grade10[10], grade10[12] }, new int[] { 98, 69, 92, 60, 99 });
            Student s127 = MakeStudent("Nicole", "Fernandez", "Russia", 10,
                new Classroom[] { grade10[7] }, new int[] { 47 });
            Student s128 = MakeStudent("Zoe", "Hill", "Vietnam", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[3], grade12[6] }, new int[] { 82, 92, 92, 66 });
            Student s129 = MakeStudent("Lena", "Holland", "Russia", 12,
                new Classroom[] { grade12[5], grade12[7] }, new int[] { 41, 79 });
            Student s130 = MakeStudent("Derek", "May", "France", 12,
                new Classroom[] { grade12[3], grade12[10], grade12[12] }, new int[] { 69, 41, 74 });
            Student s131 = MakeStudent("Tanya", "Freeman", "Vietnam", 12,
                new Classroom[] { grade12[4] }, new int[] { 90 });
            Student s132 = MakeStudent("Kay", "Kelley", "China", 11,
                new Classroom[] { grade11[2], grade11[7], grade11[11] }, new int[] { 79, 57, 91 });
            Student s133 = MakeStudent("Charlene", "Woods", "Japan", 10,
                new Classroom[] { grade10[0], grade10[7], grade10[9], grade10[10], grade10[11] }, new int[] { 91, 66, 95, 64, 97 });
            Student s134 = MakeStudent("Tina", "Campbell", "Egypt", 12,
                new Classroom[] { grade12[0], grade12[6], grade12[9] }, new int[] { 50, 52, 85 });
            Student s135 = MakeStudent("Lynn", "Gonzales", "Australia", 10,
                new Classroom[] { grade10[0] }, new int[] { 67 });
            Student s136 = MakeStudent("Roland", "Obrien", "England", 11,
                new Classroom[] { grade11[5], grade11[10], grade11[12] }, new int[] { 100, 100, 88 });
            Student s137 = MakeStudent("Kent", "Diaz", "Canada", 11,
                new Classroom[] { grade11[0] }, new int[] { 83 });
            Student s138 = MakeStudent("Vanessa", "Davidson", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[7], grade10[9], grade10[11] }, new int[] { 42, 96, 54, 48 });
            Student s139 = MakeStudent("Kathy", "Flores", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[5], grade11[10], grade11[12] }, new int[] { 76, 86, 77, 50, 47 });
            Student s140 = MakeStudent("Genesis", "Lambert", "Spain", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[10], grade12[12] }, new int[] { 81, 99, 89, 93 });
            Student s141 = MakeStudent("Kim", "Reed", "Japan", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[12] }, new int[] { 56, 58, 93 });
            Student s142 = MakeStudent("Andy", "Davis", "United States", 10,
                new Classroom[] { grade10[5], grade10[6], grade10[8], grade10[9] }, new int[] { 60, 69, 53, 70 });
            Student s143 = MakeStudent("Carrie", "Ray", "Iran", 12,
                new Classroom[] { grade12[3] }, new int[] { 61 });
            Student s144 = MakeStudent("Jeanette", "Powell", "Egypt", 12,
                new Classroom[] { grade12[5], grade12[6], grade12[8] }, new int[] { 80, 77, 71 });
            Student s145 = MakeStudent("Tyrone", "Hunt", "England", 10,
                new Classroom[] { grade10[4], grade10[6], grade10[9], grade10[10], grade10[11] }, new int[] { 42, 45, 62, 100, 100 });
            Student s146 = MakeStudent("Mia", "Herrera", "South Korea", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[4], grade12[7] }, new int[] { 96, 71, 92, 74 });
            Student s147 = MakeStudent("Kelly", "Gregory", "Vietnam", 12,
                new Classroom[] { grade12[0], grade12[5], grade12[6], grade12[10], grade12[12] }, new int[] { 99, 61, 85, 84, 94 });
            Student s148 = MakeStudent("Mitchell", "Fields", "Spain", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[3] }, new int[] { 57, 89, 79 });
            Student s149 = MakeStudent("Katrina", "Simpson", "Nigeria", 12,
                new Classroom[] { grade12[3], grade12[6], grade12[10], grade12[11] }, new int[] { 72, 72, 85, 62 });
            Student s150 = MakeStudent("Katherine", "Olson", "France", 12,
                new Classroom[] { grade12[4], grade12[6], grade12[10] }, new int[] { 75, 41, 59 });
            Student s151 = MakeStudent("Hilda", "Wells", "China", 12,
                new Classroom[] { grade12[2], grade12[3], grade12[6], grade12[7] }, new int[] { 97, 59, 49, 58 });
            Student s152 = MakeStudent("Steven", "Miles", "Turkey", 11,
                new Classroom[] { grade11[4], grade11[6], grade11[9], grade11[10], grade11[11] }, new int[] { 68, 79, 65, 58, 94 });
            Student s153 = MakeStudent("Travis", "Rice", "Nigeria", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[4], grade11[8], grade11[9] }, new int[] { 44, 44, 89, 90, 86 });
            Student s154 = MakeStudent("Morris", "Crawford", "China", 12,
                new Classroom[] { grade12[6], grade12[7], grade12[9], grade12[10], grade12[12] }, new int[] { 67, 69, 96, 68, 98 });
            Student s155 = MakeStudent("Alma", "Pierce", "England", 11,
                new Classroom[] { grade11[12] }, new int[] { 77 });
            Student s156 = MakeStudent("Stella", "Hopkins", "Greece", 11,
                new Classroom[] { grade11[4], grade11[5] }, new int[] { 45, 82 });
            Student s157 = MakeStudent("Ethan", "Davis", "Vietnam", 11,
                new Classroom[] { grade11[3], grade11[5], grade11[6], grade11[8], grade11[11] }, new int[] { 52, 62, 75, 75, 60 });
            Student s158 = MakeStudent("Brad", "Jennings", "Mexico", 12,
                new Classroom[] { grade12[11] }, new int[] { 73 });
            Student s159 = MakeStudent("Cindy", "Rivera", "Mexico", 12,
                new Classroom[] { grade12[8] }, new int[] { 100 });
            Student s160 = MakeStudent("Christy", "Kuhn", "China", 10,
                new Classroom[] { grade10[1], grade10[9] }, new int[] { 92, 69 });
            Student s161 = MakeStudent("Lesa", "Harrison", "Vietnam", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[6], grade10[8], grade10[12] }, new int[] { 95, 80, 60, 71, 74 });
            Student s162 = MakeStudent("Rene", "Curtis", "Australia", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[6] }, new int[] { 82, 96, 86 });
            Student s163 = MakeStudent("Clarence", "Welch", "Russia", 10,
                new Classroom[] { grade10[4], grade10[12] }, new int[] { 66, 80 });
            Student s164 = MakeStudent("Erin", "Obrien", "Japan", 12,
                new Classroom[] { grade12[2] }, new int[] { 47 });
            Student s165 = MakeStudent("Luis", "Perkins", "South Korea", 12,
                new Classroom[] { grade12[4], grade12[6], grade12[9], grade12[11] }, new int[] { 51, 95, 98, 45 });
            Student s166 = MakeStudent("Jessica", "Porter", "Australia", 10,
                new Classroom[] { grade10[7] }, new int[] { 54 });
            Student s167 = MakeStudent("Leona", "Gonzales", "United States", 10,
                new Classroom[] { grade10[2], grade10[4], grade10[7], grade10[8], grade10[12] }, new int[] { 91, 55, 49, 58, 85 });
            Student s168 = MakeStudent("Hannah", "Alexander", "China", 12,
                new Classroom[] { grade12[1], grade12[6], grade12[11], grade12[12] }, new int[] { 41, 50, 69, 48 });
            Student s169 = MakeStudent("Antonio", "Chambers", "England", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[9], grade10[10], grade10[12] }, new int[] { 50, 56, 68, 72, 70 });
            Student s170 = MakeStudent("Beth", "Morris", "Iran", 11,
                new Classroom[] { grade11[0], grade11[10] }, new int[] { 61, 56 });
            Student s171 = MakeStudent("Peggy", "Wilson", "United States", 10,
                new Classroom[] { grade10[7] }, new int[] { 76 });
            Student s172 = MakeStudent("Daniel", "Green", "South Korea", 10,
                new Classroom[] { grade10[1], grade10[5], grade10[7] }, new int[] { 63, 71, 68 });
            Student s173 = MakeStudent("Leonard", "Warren", "United States", 12,
                new Classroom[] { grade12[3], grade12[11] }, new int[] { 86, 82 });
            Student s174 = MakeStudent("Stephanie", "Silva", "Canada", 12,
                new Classroom[] { grade12[3], grade12[4], grade12[6], grade12[12] }, new int[] { 62, 45, 89, 53 });
            Student s175 = MakeStudent("Evelyn", "Hicks", "United States", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[6] }, new int[] { 48, 48, 68 });
            Student s176 = MakeStudent("Dustin", "Jennings", "Australia", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[8] }, new int[] { 41, 61, 87 });
            Student s177 = MakeStudent("Erin", "Cox", "Vietnam", 10,
                new Classroom[] { grade10[3], grade10[7], grade10[11] }, new int[] { 83, 87, 83 });
            Student s178 = MakeStudent("Heather", "Baker", "Canada", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[9], grade10[11], grade10[12] }, new int[] { 77, 52, 66, 55, 99 });
            Student s179 = MakeStudent("Sophie", "Russell", "Australia", 12,
                new Classroom[] { grade12[0], grade12[9], grade12[10], grade12[11] }, new int[] { 100, 41, 51, 77 });
            Student s180 = MakeStudent("Wallace", "Steward", "Nigeria", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[8] }, new int[] { 61, 53, 65 });
            Student s181 = MakeStudent("Alberto", "Gregory", "Russia", 12,
                new Classroom[] { grade12[2] }, new int[] { 88 });
            Student s182 = MakeStudent("Anna", "Allen", "Egypt", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[5], grade10[6] }, new int[] { 46, 73, 50, 80 });
            Student s183 = MakeStudent("Alex", "Young", "Spain", 10,
                new Classroom[] { grade10[1], grade10[6], grade10[7], grade10[11], grade10[12] }, new int[] { 85, 78, 65, 94, 46 });
            Student s184 = MakeStudent("Duane", "Fernandez", "France", 12,
                new Classroom[] { grade12[0], grade12[7], grade12[8] }, new int[] { 100, 53, 52 });
            Student s185 = MakeStudent("Brooklyn", "Ramos", "Spain", 11,
                new Classroom[] { grade11[2], grade11[11] }, new int[] { 53, 64 });
            Student s186 = MakeStudent("Enrique", "Scott", "Egypt", 10,
                new Classroom[] { grade10[3], grade10[4], grade10[6], grade10[8], grade10[9] }, new int[] { 41, 84, 98, 69, 100 });
            Student s187 = MakeStudent("Paula", "Myers", "Egypt", 11,
                new Classroom[] { grade11[2], grade11[6], grade11[8] }, new int[] { 57, 83, 72 });
            Student s188 = MakeStudent("Jared", "Webb", "England", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[6], grade11[9], grade11[11] }, new int[] { 47, 64, 73, 56, 48 });
            Student s189 = MakeStudent("Natalie", "Dixon", "Turkey", 11,
                new Classroom[] { grade11[6] }, new int[] { 56 });
            Student s190 = MakeStudent("Terrence", "Knight", "Japan", 11,
                new Classroom[] { grade11[2], grade11[3], grade11[4], grade11[7] }, new int[] { 88, 86, 98, 69 });
            Student s191 = MakeStudent("Chester", "Hayes", "England", 11,
                new Classroom[] { grade11[7] }, new int[] { 47 });
            Student s192 = MakeStudent("Bruce", "Richards", "Mexico", 12,
                new Classroom[] { grade12[10], grade12[11] }, new int[] { 99, 89 });
            Student s193 = MakeStudent("Naomi", "Arnold", "Russia", 11,
                new Classroom[] { grade11[9] }, new int[] { 48 });
            Student s194 = MakeStudent("Patrick", "Hicks", "Turkey", 11,
                new Classroom[] { grade11[2], grade11[6] }, new int[] { 42, 80 });
            Student s195 = MakeStudent("Noelle", "Pena", "China", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[5], grade10[6], grade10[9] }, new int[] { 55, 99, 78, 93, 84 });
            Student s196 = MakeStudent("Danny", "West", "Japan", 11,
                new Classroom[] { grade11[6], grade11[7], grade11[10] }, new int[] { 81, 40, 80 });
            Student s197 = MakeStudent("Nathan", "Lawson", "Egypt", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[11] }, new int[] { 44, 97, 45 });
            Student s198 = MakeStudent("Morris", "Patterson", "Greece", 10,
                new Classroom[] { grade10[1] }, new int[] { 42 });
            Student s199 = MakeStudent("Jerry", "Patterson", "England", 11,
                new Classroom[] { grade11[10], grade11[12] }, new int[] { 58, 44 });
            #endregion Students100-199

            #region Students200-299
            Student s200 = MakeStudent("Julian", "Berry", "Australia", 10,
                new Classroom[] { grade10[8], grade10[11] }, new int[] { 65, 76 });
            Student s201 = MakeStudent("Pat", "Smith", "United States", 10,
                new Classroom[] { grade10[0], grade10[10], grade10[11] }, new int[] { 70, 56, 57 });
            Student s202 = MakeStudent("Rosa", "Berry", "China", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[5], grade11[11], grade11[12] }, new int[] { 92, 84, 47, 83, 74 });
            Student s203 = MakeStudent("Glen", "Jensen", "Vietnam", 10,
                new Classroom[] { grade10[4], grade10[5], grade10[11] }, new int[] { 81, 96, 49 });
            Student s204 = MakeStudent("Joyce", "Wheeler", "China", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[2] }, new int[] { 44, 79, 82 });
            Student s205 = MakeStudent("Jamie", "Peck", "Japan", 10,
                new Classroom[] { grade10[9], grade10[10], grade10[12] }, new int[] { 56, 64, 46 });
            Student s206 = MakeStudent("Catherine", "Rodriguez", "Russia", 11,
                new Classroom[] { grade11[2], grade11[3], grade11[6] }, new int[] { 94, 89, 46 });
            Student s207 = MakeStudent("Arlene", "Howard", "Turkey", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[4], grade10[8] }, new int[] { 69, 74, 46, 87 });
            Student s208 = MakeStudent("Bradley", "Warren", "Turkey", 11,
                new Classroom[] { grade11[7], grade11[8], grade11[10], grade11[11], grade11[12] }, new int[] { 74, 90, 95, 83, 74 });
            Student s209 = MakeStudent("Stanley", "Olson", "Iran", 10,
                new Classroom[] { grade10[1], grade10[7], grade10[10], grade10[11] }, new int[] { 69, 62, 89, 99 });
            Student s210 = MakeStudent("Leona", "Roberts", "Greece", 12,
                new Classroom[] { grade12[3], grade12[9] }, new int[] { 42, 89 });
            Student s211 = MakeStudent("Jordan", "Wade", "Japan", 10,
                new Classroom[] { grade10[2], grade10[8], grade10[10] }, new int[] { 52, 61, 50 });
            Student s212 = MakeStudent("Myrtle", "Vasquez", "Mexico", 10,
                new Classroom[] { grade10[1], grade10[3], grade10[10], grade10[12] }, new int[] { 91, 87, 57, 73 });
            Student s213 = MakeStudent("Philip", "Ray", "Japan", 11,
                new Classroom[] { grade11[0], grade11[3], grade11[5], grade11[9] }, new int[] { 50, 83, 55, 63 });
            Student s214 = MakeStudent("Kurt", "Perry", "Vietnam", 12,
                new Classroom[] { grade12[6] }, new int[] { 68 });
            Student s215 = MakeStudent("Anne", "Reyes", "Spain", 11,
                new Classroom[] { grade11[0] }, new int[] { 44 });
            Student s216 = MakeStudent("Mason", "Roberts", "Turkey", 10,
                new Classroom[] { grade10[1], grade10[6], grade10[8], grade10[10], grade10[12] }, new int[] { 54, 43, 100, 89, 67 });
            Student s217 = MakeStudent("Patsy", "Walters", "Vietnam", 10,
                new Classroom[] { grade10[4], grade10[8], grade10[12] }, new int[] { 74, 87, 80 });
            Student s218 = MakeStudent("Shannon", "Diaz", "Vietnam", 12,
                new Classroom[] { grade12[8], grade12[11] }, new int[] { 86, 76 });
            Student s219 = MakeStudent("Nellie", "Robertson", "South Korea", 10,
                new Classroom[] { grade10[12] }, new int[] { 78 });
            Student s220 = MakeStudent("Tanya", "Gordon", "England", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[9] }, new int[] { 66, 99, 71 });
            Student s221 = MakeStudent("Dan", "Welch", "China", 12,
                new Classroom[] { grade12[3], grade12[6], grade12[7], grade12[10], grade12[12] }, new int[] { 41, 40, 66, 51, 52 });
            Student s222 = MakeStudent("Tina", "Olson", "Egypt", 11,
                new Classroom[] { grade11[5], grade11[9] }, new int[] { 96, 49 });
            Student s223 = MakeStudent("Neil", "Cooper", "England", 11,
                new Classroom[] { grade11[8] }, new int[] { 64 });
            Student s224 = MakeStudent("Kathryn", "Rodriguez", "France", 11,
                new Classroom[] { grade11[7] }, new int[] { 68 });
            Student s225 = MakeStudent("Dianne", "Ortiz", "Mexico", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[6], grade10[12] }, new int[] { 74, 55, 83, 87 });
            Student s226 = MakeStudent("Kristen", "Webb", "Canada", 11,
                new Classroom[] { grade11[1], grade11[6], grade11[7], grade11[8] }, new int[] { 79, 65, 82, 51 });
            Student s227 = MakeStudent("Bernard", "Taylor", "England", 12,
                new Classroom[] { grade12[2], grade12[7] }, new int[] { 64, 84 });
            Student s228 = MakeStudent("Zoey", "Dixon", "Canada", 10,
                new Classroom[] { grade10[1], grade10[4], grade10[9], grade10[10], grade10[12] }, new int[] { 87, 85, 78, 42, 94 });
            Student s229 = MakeStudent("Christian", "Freeman", "France", 11,
                new Classroom[] { grade11[5] }, new int[] { 94 });
            Student s230 = MakeStudent("Harry", "Simpson", "Spain", 11,
                new Classroom[] { grade11[2], grade11[7] }, new int[] { 73, 48 });
            Student s231 = MakeStudent("Alexa", "Soto", "United States", 10,
                new Classroom[] { grade10[8] }, new int[] { 65 });
            Student s232 = MakeStudent("Janet", "Vargas", "France", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[7], grade10[8], grade10[11] }, new int[] { 40, 54, 63, 80, 83 });
            Student s233 = MakeStudent("Douglas", "Fields", "Mexico", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[7], grade11[8], grade11[9] }, new int[] { 67, 61, 65, 67, 90 });
            Student s234 = MakeStudent("Aaron", "Rodriquez", "France", 12,
                new Classroom[] { grade12[0], grade12[4], grade12[8], grade12[12] }, new int[] { 69, 94, 69, 54 });
            Student s235 = MakeStudent("Dianne", "Freeman", "Egypt", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[8] }, new int[] { 60, 82, 93 });
            Student s236 = MakeStudent("Arron", "Morales", "Greece", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[10], grade12[12] }, new int[] { 60, 74, 89, 78 });
            Student s237 = MakeStudent("Madison", "Snyder", "Japan", 12,
                new Classroom[] { grade12[10] }, new int[] { 57 });
            Student s238 = MakeStudent("Fred", "Carlson", "Japan", 11,
                new Classroom[] { grade11[1], grade11[8] }, new int[] { 46, 44 });
            Student s239 = MakeStudent("Earl", "Gomez", "Egypt", 12,
                new Classroom[] { grade12[4], grade12[5] }, new int[] { 58, 87 });
            Student s240 = MakeStudent("Terra", "Johnson", "Greece", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[9], grade12[11] }, new int[] { 91, 69, 52, 68 });
            Student s241 = MakeStudent("George", "Spencer", "United States", 12,
                new Classroom[] { grade12[12] }, new int[] { 98 });
            Student s242 = MakeStudent("Freddie", "Franklin", "Vietnam", 12,
                new Classroom[] { grade12[7], grade12[11], grade12[12] }, new int[] { 88, 89, 95 });
            Student s243 = MakeStudent("Justin", "Tucker", "France", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[6], grade10[8] }, new int[] { 67, 74, 53, 61 });
            Student s244 = MakeStudent("Amber", "Rose", "Nigeria", 12,
                new Classroom[] { grade12[5] }, new int[] { 57 });
            Student s245 = MakeStudent("Clifford", "Brown", "Vietnam", 10,
                new Classroom[] { grade10[3], grade10[7] }, new int[] { 43, 78 });
            Student s246 = MakeStudent("Zack", "Douglas", "Nigeria", 10,
                new Classroom[] { grade10[1], grade10[11] }, new int[] { 66, 92 });
            Student s247 = MakeStudent("Heidi", "Peck", "France", 11,
                new Classroom[] { grade11[1], grade11[6] }, new int[] { 58, 61 });
            Student s248 = MakeStudent("Valerie", "Hansen", "Mexico", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[3], grade12[10], grade12[12] }, new int[] { 69, 67, 74, 93, 89 });
            Student s249 = MakeStudent("Darrell", "Austin", "United States", 11,
                new Classroom[] { grade11[3], grade11[4], grade11[9], grade11[10] }, new int[] { 76, 50, 47, 84 });
            Student s250 = MakeStudent("Ronald", "Black", "Egypt", 10,
                new Classroom[] { grade10[1], grade10[5], grade10[6], grade10[7], grade10[12] }, new int[] { 100, 66, 49, 79, 40 });
            Student s251 = MakeStudent("Frank", "Fuller", "England", 10,
                new Classroom[] { grade10[6], grade10[7] }, new int[] { 76, 83 });
            Student s252 = MakeStudent("Kenzi", "Pearson", "United States", 10,
                new Classroom[] { grade10[2], grade10[3], grade10[9], grade10[11], grade10[12] }, new int[] { 76, 52, 67, 79, 79 });
            Student s253 = MakeStudent("Justin", "Bryant", "Greece", 12,
                new Classroom[] { grade12[8], grade12[9] }, new int[] { 85, 99 });
            Student s254 = MakeStudent("Shelly", "Hill", "France", 11,
                new Classroom[] { grade11[5], grade11[6], grade11[7], grade11[11] }, new int[] { 64, 92, 82, 63 });
            Student s255 = MakeStudent("Stacy", "Harper", "Mexico", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[2] }, new int[] { 44, 65, 58 });
            Student s256 = MakeStudent("Barry", "Owens", "Australia", 12,
                new Classroom[] { grade12[4] }, new int[] { 52 });
            Student s257 = MakeStudent("Terrance", "Gonzalez", "Spain", 12,
                new Classroom[] { grade12[8], grade12[10], grade12[12] }, new int[] { 61, 70, 80 });
            Student s258 = MakeStudent("Seth", "Flores", "Iran", 12,
                new Classroom[] { grade12[2], grade12[4], grade12[10], grade12[11], grade12[12] }, new int[] { 86, 93, 43, 72, 74 });
            Student s259 = MakeStudent("Vincent", "Roberts", "Nigeria", 10,
                new Classroom[] { grade10[4] }, new int[] { 66 });
            Student s260 = MakeStudent("Timmothy", "Cox", "England", 12,
                new Classroom[] { grade12[2], grade12[4] }, new int[] { 94, 65 });
            Student s261 = MakeStudent("Darlene", "Owens", "United States", 10,
                new Classroom[] { grade10[2], grade10[8] }, new int[] { 92, 50 });
            Student s262 = MakeStudent("Brianna", "Hoffman", "South Korea", 10,
                new Classroom[] { grade10[3], grade10[7], grade10[10] }, new int[] { 72, 67, 58 });
            Student s263 = MakeStudent("Marian", "Gregory", "Canada", 11,
                new Classroom[] { grade11[2], grade11[3], grade11[7], grade11[10] }, new int[] { 46, 56, 82, 77 });
            Student s264 = MakeStudent("Lauren", "Ford", "South Korea", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[5], grade12[10] }, new int[] { 91, 45, 62, 93 });
            Student s265 = MakeStudent("Mattie", "Miles", "Canada", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[10], grade11[12] }, new int[] { 52, 67, 79, 100 });
            Student s266 = MakeStudent("Willard", "Boyd", "Nigeria", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[2], grade10[3], grade10[5] }, new int[] { 99, 83, 93, 47, 55 });
            Student s267 = MakeStudent("Samuel", "Wood", "Australia", 10,
                new Classroom[] { grade10[0], grade10[6], grade10[7], grade10[8], grade10[12] }, new int[] { 86, 79, 97, 45, 45 });
            Student s268 = MakeStudent("Guy", "Fox", "Russia", 12,
                new Classroom[] { grade12[4] }, new int[] { 82 });
            Student s269 = MakeStudent("Gwendolyn", "Nichols", "United States", 10,
                new Classroom[] { grade10[10] }, new int[] { 53 });
            Student s270 = MakeStudent("Hannah", "Flores", "England", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[6], grade10[8], grade10[12] }, new int[] { 74, 93, 84, 85, 92 });
            Student s271 = MakeStudent("Freddie", "Stanley", "Nigeria", 11,
                new Classroom[] { grade11[1], grade11[2], grade11[4], grade11[9], grade11[10] }, new int[] { 72, 89, 81, 87, 43 });
            Student s272 = MakeStudent("Pauline", "Lopez", "Egypt", 12,
                new Classroom[] { grade12[0], grade12[6], grade12[10] }, new int[] { 45, 94, 75 });
            Student s273 = MakeStudent("Brian", "Roberts", "Turkey", 11,
                new Classroom[] { grade11[1], grade11[2] }, new int[] { 98, 49 });
            Student s274 = MakeStudent("Caleb", "Bishop", "Russia", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[6], grade12[8], grade12[11] }, new int[] { 96, 46, 63, 59, 51 });
            Student s275 = MakeStudent("Esther", "Garrett", "Egypt", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[11] }, new int[] { 88, 54, 51 });
            Student s276 = MakeStudent("Shelly", "King", "Russia", 11,
                new Classroom[] { grade11[5], grade11[10] }, new int[] { 88, 59 });
            Student s277 = MakeStudent("Jamie", "Silva", "Iran", 10,
                new Classroom[] { grade10[2], grade10[3] }, new int[] { 76, 50 });
            Student s278 = MakeStudent("Myrtle", "Wells", "Nigeria", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[4], grade10[10], grade10[12] }, new int[] { 83, 97, 61, 67, 87 });
            Student s279 = MakeStudent("Samuel", "Horton", "Australia", 11,
                new Classroom[] { grade11[2], grade11[9] }, new int[] { 94, 81 });
            Student s280 = MakeStudent("Ana", "Murray", "Iran", 12,
                new Classroom[] { grade12[0], grade12[4], grade12[5], grade12[6], grade12[8] }, new int[] { 55, 70, 52, 41, 50 });
            Student s281 = MakeStudent("Lori", "Lopez", "Australia", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[5], grade11[8], grade11[12] }, new int[] { 55, 74, 46, 73, 72 });
            Student s282 = MakeStudent("Nevaeh", "Hale", "Spain", 10,
                new Classroom[] { grade10[10] }, new int[] { 57 });
            Student s283 = MakeStudent("Jamie", "Mitchelle", "England", 10,
                new Classroom[] { grade10[6], grade10[7] }, new int[] { 52, 100 });
            Student s284 = MakeStudent("Stanley", "Jennings", "Greece", 11,
                new Classroom[] { grade11[7], grade11[12] }, new int[] { 58, 91 });
            Student s285 = MakeStudent("Jeffery", "Jimenez", "United States", 11,
                new Classroom[] { grade11[0] }, new int[] { 72 });
            Student s286 = MakeStudent("Gilbert", "Perez", "Japan", 12,
                new Classroom[] { grade12[1], grade12[11] }, new int[] { 59, 48 });
            Student s287 = MakeStudent("Michele", "Lucas", "South Korea", 10,
                new Classroom[] { grade10[10] }, new int[] { 95 });
            Student s288 = MakeStudent("Marlene", "Scott", "Mexico", 12,
                new Classroom[] { grade12[5], grade12[11] }, new int[] { 89, 70 });
            Student s289 = MakeStudent("Edwin", "Rhodes", "France", 10,
                new Classroom[] { grade10[3], grade10[8], grade10[10], grade10[12] }, new int[] { 73, 68, 83, 54 });
            Student s290 = MakeStudent("Landon", "Gilbert", "South Korea", 10,
                new Classroom[] { grade10[7], grade10[10] }, new int[] { 96, 87 });
            Student s291 = MakeStudent("Ann", "Rose", "United States", 11,
                new Classroom[] { grade11[2], grade11[3], grade11[5], grade11[8] }, new int[] { 86, 48, 76, 72 });
            Student s292 = MakeStudent("Eddie", "Lee", "Iran", 12,
                new Classroom[] { grade12[9] }, new int[] { 87 });
            Student s293 = MakeStudent("Gladys", "Cook", "Canada", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[3], grade10[7], grade10[10] }, new int[] { 76, 71, 82, 53, 48 });
            Student s294 = MakeStudent("Joy", "Johnston", "China", 10,
                new Classroom[] { grade10[3], grade10[6] }, new int[] { 99, 79 });
            Student s295 = MakeStudent("Ernest", "Hicks", "Turkey", 10,
                new Classroom[] { grade10[1], grade10[3] }, new int[] { 94, 68 });
            Student s296 = MakeStudent("Phillip", "Evans", "Spain", 12,
                new Classroom[] { grade12[7], grade12[8], grade12[9] }, new int[] { 71, 60, 94 });
            Student s297 = MakeStudent("Joshua", "Lopez", "Vietnam", 10,
                new Classroom[] { grade10[3], grade10[6], grade10[12] }, new int[] { 64, 94, 72 });
            Student s298 = MakeStudent("Savannah", "Allen", "Canada", 10,
                new Classroom[] { grade10[3], grade10[8] }, new int[] { 86, 73 });
            Student s299 = MakeStudent("Patrick", "Black", "United States", 10,
                new Classroom[] { grade10[5], grade10[8] }, new int[] { 48, 45 });
            #endregion Students200-299

            #region Students300-399
            Student s300 = MakeStudent("Celina", "Carr", "South Korea", 12,
                new Classroom[] { grade12[2] }, new int[] { 51 });
            Student s301 = MakeStudent("Franklin", "Day", "Turkey", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[4], grade12[6], grade12[12] }, new int[] { 87, 89, 86, 86, 68 });
            Student s302 = MakeStudent("Tamara", "Simpson", "England", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[11] }, new int[] { 54, 90, 57 });
            Student s303 = MakeStudent("Donald", "Fisher", "South Korea", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[7] }, new int[] { 96, 91, 95 });
            Student s304 = MakeStudent("Roy", "Miles", "Greece", 10,
                new Classroom[] { grade10[2], grade10[3], grade10[10], grade10[11], grade10[12] }, new int[] { 51, 88, 73, 65, 66 });
            Student s305 = MakeStudent("Debra", "White", "Turkey", 11,
                new Classroom[] { grade11[0] }, new int[] { 70 });
            Student s306 = MakeStudent("Wayne", "Stanley", "Turkey", 12,
                new Classroom[] { grade12[0], grade12[2] }, new int[] { 67, 87 });
            Student s307 = MakeStudent("Jane", "Pierce", "Russia", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[12] }, new int[] { 79, 82, 95 });
            Student s308 = MakeStudent("Jeff", "Weaver", "Russia", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[7], grade10[9] }, new int[] { 100, 93, 48, 68 });
            Student s309 = MakeStudent("Pedro", "Torres", "Greece", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[6], grade11[9] }, new int[] { 78, 64, 78, 98 });
            Student s310 = MakeStudent("Lee", "Stewart", "Mexico", 12,
                new Classroom[] { grade12[3], grade12[5], grade12[10] }, new int[] { 50, 86, 44 });
            Student s311 = MakeStudent("Kent", "Ray", "Egypt", 12,
                new Classroom[] { grade12[6], grade12[9] }, new int[] { 60, 54 });
            Student s312 = MakeStudent("Harper", "Stevens", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[12] }, new int[] { 74, 40 });
            Student s313 = MakeStudent("Gerald", "Harrison", "Turkey", 11,
                new Classroom[] { grade11[1], grade11[6] }, new int[] { 59, 82 });
            Student s314 = MakeStudent("Tracey", "Daniels", "Nigeria", 11,
                new Classroom[] { grade11[2], grade11[4], grade11[8] }, new int[] { 74, 41, 55 });
            Student s315 = MakeStudent("Lily", "Brooks", "Nigeria", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[2], grade11[9], grade11[11] }, new int[] { 67, 52, 100, 80, 48 });
            Student s316 = MakeStudent("Sophia", "Thompson", "China", 10,
                new Classroom[] { grade10[12] }, new int[] { 72 });
            Student s317 = MakeStudent("Letitia", "Beck", "United States", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[7], grade11[10], grade11[11] }, new int[] { 93, 59, 88, 58, 99 });
            Student s318 = MakeStudent("Tonya", "Stanley", "England", 12,
                new Classroom[] { grade12[10] }, new int[] { 46 });
            Student s319 = MakeStudent("Felecia", "Foster", "Canada", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[12] }, new int[] { 44, 85, 83 });
            Student s320 = MakeStudent("Kristin", "Owens", "Spain", 12,
                new Classroom[] { grade12[4], grade12[5], grade12[6], grade12[7], grade12[11] }, new int[] { 71, 77, 64, 79, 45 });
            Student s321 = MakeStudent("Suzanne", "Terry", "Iran", 12,
                new Classroom[] { grade12[4], grade12[8], grade12[11] }, new int[] { 45, 62, 89 });
            Student s322 = MakeStudent("Marlene", "Silva", "France", 12,
                new Classroom[] { grade12[2] }, new int[] { 40 });
            Student s323 = MakeStudent("Zoey", "Steward", "China", 11,
                new Classroom[] { grade11[8], grade11[12] }, new int[] { 71, 50 });
            Student s324 = MakeStudent("Jane", "Byrd", "China", 12,
                new Classroom[] { grade12[10], grade12[12] }, new int[] { 89, 40 });
            Student s325 = MakeStudent("Michele", "Anderson", "Mexico", 11,
                new Classroom[] { grade11[4], grade11[5], grade11[12] }, new int[] { 49, 96, 41 });
            Student s326 = MakeStudent("Alex", "Rivera", "China", 10,
                new Classroom[] { grade10[4], grade10[5], grade10[7], grade10[9] }, new int[] { 95, 87, 64, 48 });
            Student s327 = MakeStudent("Hannah", "King", "South Korea", 11,
                new Classroom[] { grade11[8] }, new int[] { 73 });
            Student s328 = MakeStudent("Regina", "Johnson", "Japan", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[8] }, new int[] { 75, 93, 63 });
            Student s329 = MakeStudent("Milton", "Allen", "Vietnam", 10,
                new Classroom[] { grade10[9], grade10[12] }, new int[] { 41, 61 });
            Student s330 = MakeStudent("Jose", "George", "Iran", 11,
                new Classroom[] { grade11[1], grade11[6], grade11[7], grade11[11] }, new int[] { 41, 86, 55, 77 });
            Student s331 = MakeStudent("Lucas", "Wallace", "Iran", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[6], grade12[7], grade12[9] }, new int[] { 58, 55, 79, 58, 57 });
            Student s332 = MakeStudent("Christina", "Bennett", "China", 12,
                new Classroom[] { grade12[3], grade12[6], grade12[10], grade12[12] }, new int[] { 54, 49, 44, 71 });
            Student s333 = MakeStudent("Victoria", "Carter", "Spain", 12,
                new Classroom[] { grade12[3], grade12[4], grade12[7], grade12[8], grade12[11] }, new int[] { 67, 78, 65, 89, 84 });
            Student s334 = MakeStudent("Janice", "Wilson", "Vietnam", 12,
                new Classroom[] { grade12[7], grade12[10] }, new int[] { 62, 81 });
            Student s335 = MakeStudent("Seth", "Carter", "Greece", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[10], grade10[11] }, new int[] { 73, 91, 83, 96 });
            Student s336 = MakeStudent("Edward", "Walker", "China", 12,
                new Classroom[] { grade12[4] }, new int[] { 55 });
            Student s337 = MakeStudent("Bessie", "Riley", "Russia", 10,
                new Classroom[] { grade10[5], grade10[6], grade10[7], grade10[10], grade10[12] }, new int[] { 96, 44, 81, 72, 58 });
            Student s338 = MakeStudent("Deann", "Dean", "Vietnam", 10,
                new Classroom[] { grade10[0], grade10[4], grade10[8], grade10[10], grade10[12] }, new int[] { 66, 58, 60, 62, 59 });
            Student s339 = MakeStudent("Everett", "Henderson", "England", 12,
                new Classroom[] { grade12[5], grade12[8] }, new int[] { 85, 53 });
            Student s340 = MakeStudent("Barry", "Daniels", "Australia", 12,
                new Classroom[] { grade12[0], grade12[5], grade12[11] }, new int[] { 80, 81, 67 });
            Student s341 = MakeStudent("Marian", "Stanley", "Canada", 12,
                new Classroom[] { grade12[0] }, new int[] { 64 });
            Student s342 = MakeStudent("George", "Neal", "Mexico", 11,
                new Classroom[] { grade11[1], grade11[5], grade11[9], grade11[12] }, new int[] { 52, 48, 96, 59 });
            Student s343 = MakeStudent("Theodore", "Hudson", "Spain", 12,
                new Classroom[] { grade12[7] }, new int[] { 40 });
            Student s344 = MakeStudent("Kenneth", "Newman", "Mexico", 12,
                new Classroom[] { grade12[5], grade12[10] }, new int[] { 90, 82 });
            Student s345 = MakeStudent("Christopher", "Campbell", "Greece", 10,
                new Classroom[] { grade10[5], grade10[6] }, new int[] { 74, 86 });
            Student s346 = MakeStudent("Ashley", "Fisher", "South Korea", 10,
                new Classroom[] { grade10[3], grade10[5], grade10[7] }, new int[] { 88, 41, 69 });
            Student s347 = MakeStudent("Steve", "Carroll", "Mexico", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[12] }, new int[] { 71, 44, 52 });
            Student s348 = MakeStudent("Daryl", "Hoffman", "South Korea", 11,
                new Classroom[] { grade11[4], grade11[7], grade11[9] }, new int[] { 73, 44, 90 });
            Student s349 = MakeStudent("Wesley", "Hill", "Spain", 12,
                new Classroom[] { grade12[2], grade12[3], grade12[4], grade12[8] }, new int[] { 92, 68, 78, 76 });
            Student s350 = MakeStudent("Guy", "Hicks", "Mexico", 10,
                new Classroom[] { grade10[3], grade10[5], grade10[10], grade10[11] }, new int[] { 87, 50, 85, 98 });
            Student s351 = MakeStudent("Ricardo", "Ford", "Vietnam", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[3], grade12[8], grade12[9] }, new int[] { 48, 59, 70, 78, 61 });
            Student s352 = MakeStudent("Bryan", "West", "Russia", 10,
                new Classroom[] { grade10[2], grade10[5], grade10[10], grade10[11] }, new int[] { 93, 61, 97, 69 });
            Student s353 = MakeStudent("Willie", "Gilbert", "China", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[6], grade11[10], grade11[12] }, new int[] { 64, 84, 63, 45, 84 });
            Student s354 = MakeStudent("Elmer", "Day", "Turkey", 11,
                new Classroom[] { grade11[2], grade11[9], grade11[12] }, new int[] { 43, 92, 87 });
            Student s355 = MakeStudent("Juan", "Ellis", "Greece", 10,
                new Classroom[] { grade10[10] }, new int[] { 52 });
            Student s356 = MakeStudent("Landon", "Mills", "Canada", 11,
                new Classroom[] { grade11[6], grade11[12] }, new int[] { 79, 70 });
            Student s357 = MakeStudent("Dale", "Bowman", "Iran", 11,
                new Classroom[] { grade11[1], grade11[5], grade11[7] }, new int[] { 58, 76, 74 });
            Student s358 = MakeStudent("Becky", "Murphy", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[9] }, new int[] { 75, 53, 40 });
            Student s359 = MakeStudent("Harvey", "Russell", "South Korea", 11,
                new Classroom[] { grade11[3], grade11[8], grade11[10], grade11[11] }, new int[] { 82, 71, 79, 62 });
            Student s360 = MakeStudent("Tonya", "Mitchelle", "Vietnam", 10,
                new Classroom[] { grade10[12] }, new int[] { 78 });
            Student s361 = MakeStudent("Katie", "Young", "Spain", 10,
                new Classroom[] { grade10[4], grade10[5], grade10[11] }, new int[] { 40, 59, 47 });
            Student s362 = MakeStudent("June", "Green", "Canada", 11,
                new Classroom[] { grade11[11] }, new int[] { 40 });
            Student s363 = MakeStudent("Jeffrey", "Price", "Mexico", 10,
                new Classroom[] { grade10[0], grade10[8], grade10[9] }, new int[] { 66, 56, 89 });
            Student s364 = MakeStudent("Craig", "Miller", "Australia", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[6], grade11[12] }, new int[] { 60, 47, 68, 64 });
            Student s365 = MakeStudent("Matthew", "Douglas", "Egypt", 10,
                new Classroom[] { grade10[2], grade10[3], grade10[7], grade10[10], grade10[12] }, new int[] { 51, 49, 63, 77, 75 });
            Student s366 = MakeStudent("Janice", "Ray", "Iran", 11,
                new Classroom[] { grade11[10] }, new int[] { 47 });
            Student s367 = MakeStudent("Wade", "Vasquez", "Russia", 12,
                new Classroom[] { grade12[5], grade12[7] }, new int[] { 74, 62 });
            Student s368 = MakeStudent("Edgar", "Hill", "Australia", 11,
                new Classroom[] { grade11[5], grade11[8] }, new int[] { 49, 56 });
            Student s369 = MakeStudent("George", "Bailey", "Nigeria", 12,
                new Classroom[] { grade12[1], grade12[3], grade12[9] }, new int[] { 53, 71, 100 });
            Student s370 = MakeStudent("Delores", "Weaver", "Japan", 11,
                new Classroom[] { grade11[4], grade11[7], grade11[9], grade11[11] }, new int[] { 83, 73, 98, 55 });
            Student s371 = MakeStudent("Lee", "Jones", "Russia", 11,
                new Classroom[] { grade11[8] }, new int[] { 49 });
            Student s372 = MakeStudent("Danielle", "Carter", "Spain", 10,
                new Classroom[] { grade10[6] }, new int[] { 52 });
            Student s373 = MakeStudent("Norma", "Grant", "England", 11,
                new Classroom[] { grade11[3], grade11[5], grade11[10] }, new int[] { 53, 48, 82 });
            Student s374 = MakeStudent("Ellen", "Allen", "South Korea", 12,
                new Classroom[] { grade12[1] }, new int[] { 70 });
            Student s375 = MakeStudent("Adrian", "Cook", "China", 10,
                new Classroom[] { grade10[3] }, new int[] { 75 });
            Student s376 = MakeStudent("Gary", "Anderson", "Australia", 12,
                new Classroom[] { grade12[4], grade12[5] }, new int[] { 55, 60 });
            Student s377 = MakeStudent("Gabriel", "Ford", "Turkey", 11,
                new Classroom[] { grade11[3] }, new int[] { 82 });
            Student s378 = MakeStudent("Jenny", "Barrett", "South Korea", 11,
                new Classroom[] { grade11[0], grade11[8], grade11[11], grade11[12] }, new int[] { 80, 79, 58, 74 });
            Student s379 = MakeStudent("Clarence", "Simmmons", "Nigeria", 12,
                new Classroom[] { grade12[6], grade12[8], grade12[11] }, new int[] { 81, 70, 83 });
            Student s380 = MakeStudent("Oscar", "Martin", "England", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[3], grade10[10], grade10[12] }, new int[] { 40, 76, 86, 93, 64 });
            Student s381 = MakeStudent("Joann", "Holt", "Spain", 11,
                new Classroom[] { grade11[8] }, new int[] { 71 });
            Student s382 = MakeStudent("Zachary", "Bailey", "France", 10,
                new Classroom[] { grade10[8], grade10[11], grade10[12] }, new int[] { 75, 50, 58 });
            Student s383 = MakeStudent("Micheal", "Young", "Iran", 11,
                new Classroom[] { grade11[11], grade11[12] }, new int[] { 54, 54 });
            Student s384 = MakeStudent("John", "Rivera", "Japan", 12,
                new Classroom[] { grade12[1], grade12[6], grade12[9], grade12[10], grade12[12] }, new int[] { 94, 49, 79, 91, 84 });
            Student s385 = MakeStudent("Gary", "Jennings", "Japan", 12,
                new Classroom[] { grade12[3], grade12[6], grade12[9] }, new int[] { 86, 62, 82 });
            Student s386 = MakeStudent("Rose", "Montgomery", "Canada", 11,
                new Classroom[] { grade11[11] }, new int[] { 53 });
            Student s387 = MakeStudent("Loretta", "Scott", "Japan", 11,
                new Classroom[] { grade11[1], grade11[3], grade11[9], grade11[11] }, new int[] { 96, 49, 80, 90 });
            Student s388 = MakeStudent("Brianna", "Howell", "Russia", 12,
                new Classroom[] { grade12[4], grade12[6] }, new int[] { 87, 41 });
            Student s389 = MakeStudent("Kyle", "Gregory", "China", 11,
                new Classroom[] { grade11[4], grade11[5], grade11[6], grade11[7], grade11[12] }, new int[] { 58, 85, 70, 55, 75 });
            Student s390 = MakeStudent("Scott", "Pierce", "Russia", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[6], grade10[8], grade10[10] }, new int[] { 98, 86, 88, 82, 48 });
            Student s391 = MakeStudent("Darrell", "Lewis", "England", 12,
                new Classroom[] { grade12[0], grade12[5], grade12[10], grade12[11] }, new int[] { 56, 83, 82, 78 });
            Student s392 = MakeStudent("Clifton", "Bennett", "Canada", 12,
                new Classroom[] { grade12[6] }, new int[] { 93 });
            Student s393 = MakeStudent("Marcia", "Warren", "China", 12,
                new Classroom[] { grade12[3], grade12[4], grade12[9], grade12[10] }, new int[] { 91, 57, 47, 96 });
            Student s394 = MakeStudent("Brett", "Curtis", "Australia", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[4], grade12[6], grade12[9] }, new int[] { 77, 87, 68, 49, 100 });
            Student s395 = MakeStudent("Monica", "Schmidt", "Japan", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[8], grade11[11] }, new int[] { 53, 98, 62, 44 });
            Student s396 = MakeStudent("Bella", "Gutierrez", "England", 10,
                new Classroom[] { grade10[0], grade10[5] }, new int[] { 95, 73 });
            Student s397 = MakeStudent("Theodore", "Crawford", "South Korea", 11,
                new Classroom[] { grade11[0] }, new int[] { 48 });
            Student s398 = MakeStudent("Mae", "Gordon", "United States", 12,
                new Classroom[] { grade12[2] }, new int[] { 70 });
            Student s399 = MakeStudent("Brayden", "Miller", "Egypt", 12,
                new Classroom[] { grade12[3], grade12[4], grade12[8], grade12[9] }, new int[] { 98, 66, 55, 67 });
            #endregion Students300-399

            #region Students400-499
            Student s400 = MakeStudent("Jeremy", "Turner", "Spain", 12,
                new Classroom[] { grade12[6] }, new int[] { 48 });
            Student s401 = MakeStudent("Bobbie", "Garrett", "Greece", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[8], grade11[9], grade11[10] }, new int[] { 80, 65, 82, 43, 43 });
            Student s402 = MakeStudent("Lawrence", "Vargas", "United States", 11,
                new Classroom[] { grade11[12] }, new int[] { 54 });
            Student s403 = MakeStudent("Patsy", "Martinez", "Russia", 12,
                new Classroom[] { grade12[9] }, new int[] { 50 });
            Student s404 = MakeStudent("Judd", "Vargas", "United States", 10,
                new Classroom[] { grade10[1], grade10[2], grade10[6], grade10[7], grade10[8] }, new int[] { 54, 61, 100, 85, 81 });
            Student s405 = MakeStudent("Harold", "Pierce", "Japan", 10,
                new Classroom[] { grade10[4] }, new int[] { 84 });
            Student s406 = MakeStudent("Amy", "Ryan", "China", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[9] }, new int[] { 87, 90, 80 });
            Student s407 = MakeStudent("Carolyn", "Porter", "Mexico", 12,
                new Classroom[] { grade12[8], grade12[11] }, new int[] { 75, 96 });
            Student s408 = MakeStudent("Savannah", "Fields", "England", 10,
                new Classroom[] { grade10[4] }, new int[] { 41 });
            Student s409 = MakeStudent("Brooklyn", "Hopkins", "Japan", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[10] }, new int[] { 80, 69, 74 });
            Student s410 = MakeStudent("Herminia", "Garza", "France", 10,
                new Classroom[] { grade10[2], grade10[4], grade10[6] }, new int[] { 71, 64, 83 });
            Student s411 = MakeStudent("Christian", "Medina", "Mexico", 10,
                new Classroom[] { grade10[11] }, new int[] { 61 });
            Student s412 = MakeStudent("Joann", "Bailey", "France", 11,
                new Classroom[] { grade11[3], grade11[11] }, new int[] { 74, 47 });
            Student s413 = MakeStudent("Caroline", "Lowe", "United States", 11,
                new Classroom[] { grade11[2], grade11[4] }, new int[] { 88, 83 });
            Student s414 = MakeStudent("Cecil", "Newman", "Australia", 12,
                new Classroom[] { grade12[3], grade12[4], grade12[5], grade12[12] }, new int[] { 90, 91, 84, 78 });
            Student s415 = MakeStudent("Jackson", "Chavez", "Iran", 10,
                new Classroom[] { grade10[7], grade10[10], grade10[11] }, new int[] { 45, 42, 63 });
            Student s416 = MakeStudent("Liam", "Newman", "Spain", 12,
                new Classroom[] { grade12[5] }, new int[] { 54 });
            Student s417 = MakeStudent("Harold", "Newman", "Nigeria", 12,
                new Classroom[] { grade12[1], grade12[3], grade12[4], grade12[9] }, new int[] { 73, 48, 67, 91 });
            Student s418 = MakeStudent("Christina", "Kelly", "Nigeria", 11,
                new Classroom[] { grade11[1], grade11[5], grade11[10] }, new int[] { 85, 50, 58 });
            Student s419 = MakeStudent("Bessie", "Welch", "Egypt", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[7] }, new int[] { 50, 50, 79 });
            Student s420 = MakeStudent("Marjorie", "Rhodes", "Nigeria", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[8] }, new int[] { 78, 57, 49 });
            Student s421 = MakeStudent("Glen", "Soto", "United States", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[8] }, new int[] { 56, 81, 50 });
            Student s422 = MakeStudent("Edgar", "Dixon", "Vietnam", 11,
                new Classroom[] { grade11[4] }, new int[] { 65 });
            Student s423 = MakeStudent("Gail", "Sanders", "Australia", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[4], grade10[6] }, new int[] { 51, 74, 68, 69 });
            Student s424 = MakeStudent("Jo", "Shelton", "Egypt", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[6], grade10[7], grade10[8] }, new int[] { 84, 71, 80, 65, 87 });
            Student s425 = MakeStudent("Reginald", "Patterson", "Turkey", 12,
                new Classroom[] { grade12[2], grade12[4], grade12[7] }, new int[] { 52, 59, 85 });
            Student s426 = MakeStudent("Randall", "Peters", "Japan", 10,
                new Classroom[] { grade10[5] }, new int[] { 53 });
            Student s427 = MakeStudent("Jerry", "Perry", "Spain", 10,
                new Classroom[] { grade10[5] }, new int[] { 48 });
            Student s428 = MakeStudent("Stacey", "Gomez", "Egypt", 11,
                new Classroom[] { grade11[7], grade11[12] }, new int[] { 68, 93 });
            Student s429 = MakeStudent("Robert", "White", "France", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[7] }, new int[] { 78, 53, 64 });
            Student s430 = MakeStudent("Priscilla", "Green", "Nigeria", 12,
                new Classroom[] { grade12[0], grade12[10] }, new int[] { 92, 64 });
            Student s431 = MakeStudent("Warren", "Lawson", "Russia", 10,
                new Classroom[] { grade10[5], grade10[10], grade10[12] }, new int[] { 96, 73, 62 });
            Student s432 = MakeStudent("David", "Arnold", "Egypt", 12,
                new Classroom[] { grade12[2], grade12[4], grade12[8], grade12[9], grade12[12] }, new int[] { 72, 73, 87, 83, 60 });
            Student s433 = MakeStudent("Colleen", "Russell", "Mexico", 10,
                new Classroom[] { grade10[1] }, new int[] { 47 });
            Student s434 = MakeStudent("Rachel", "Bailey", "Iran", 10,
                new Classroom[] { grade10[7] }, new int[] { 77 });
            Student s435 = MakeStudent("Elaine", "Harris", "Egypt", 12,
                new Classroom[] { grade12[5], grade12[7] }, new int[] { 55, 73 });
            Student s436 = MakeStudent("Mary", "Ferguson", "Japan", 10,
                new Classroom[] { grade10[0], grade10[4], grade10[6], grade10[7] }, new int[] { 83, 91, 57, 100 });
            Student s437 = MakeStudent("Julia", "Mcdonalid", "England", 10,
                new Classroom[] { grade10[5], grade10[9] }, new int[] { 86, 68 });
            Student s438 = MakeStudent("Peyton", "Johnson", "Canada", 11,
                new Classroom[] { grade11[1], grade11[7] }, new int[] { 48, 94 });
            Student s439 = MakeStudent("Felicia", "Morgan", "Russia", 12,
                new Classroom[] { grade12[0], grade12[2], grade12[6], grade12[7], grade12[10] }, new int[] { 53, 83, 41, 78, 67 });
            Student s440 = MakeStudent("Genesis", "Williamson", "Vietnam", 10,
                new Classroom[] { grade10[11] }, new int[] { 46 });
            Student s441 = MakeStudent("Leon", "Ward", "Canada", 12,
                new Classroom[] { grade12[11] }, new int[] { 51 });
            Student s442 = MakeStudent("Carole", "Tucker", "France", 12,
                new Classroom[] { grade12[0], grade12[3], grade12[4], grade12[10], grade12[11] }, new int[] { 93, 87, 44, 70, 96 });
            Student s443 = MakeStudent("Eva", "Davis", "Turkey", 12,
                new Classroom[] { grade12[1], grade12[3], grade12[5], grade12[6], grade12[8] }, new int[] { 50, 87, 40, 81, 96 });
            Student s444 = MakeStudent("Kent", "Collins", "Spain", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[7], grade12[10], grade12[11] }, new int[] { 77, 52, 84, 71, 43 });
            Student s445 = MakeStudent("Minnie", "Kennedy", "Iran", 10,
                new Classroom[] { grade10[9], grade10[11] }, new int[] { 70, 78 });
            Student s446 = MakeStudent("Tamara", "Gomez", "China", 12,
                new Classroom[] { grade12[2] }, new int[] { 58 });
            Student s447 = MakeStudent("Jeremy", "Moore", "Nigeria", 11,
                new Classroom[] { grade11[12] }, new int[] { 43 });
            Student s448 = MakeStudent("Ava", "Sullivan", "Greece", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[4], grade11[8] }, new int[] { 65, 43, 69, 91 });
            Student s449 = MakeStudent("Walter", "Rhodes", "Iran", 11,
                new Classroom[] { grade11[0], grade11[2], grade11[3], grade11[9], grade11[10] }, new int[] { 94, 79, 97, 56, 95 });
            Student s450 = MakeStudent("Ross", "Daniels", "England", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[2], grade12[9], grade12[11] }, new int[] { 45, 49, 68, 88, 65 });
            Student s451 = MakeStudent("Mitchell", "Rodriquez", "Russia", 12,
                new Classroom[] { grade12[4], grade12[12] }, new int[] { 88, 94 });
            Student s452 = MakeStudent("Lloyd", "Montgomery", "Japan", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[3], grade10[4], grade10[8] }, new int[] { 84, 98, 73, 44, 82 });
            Student s453 = MakeStudent("Wallace", "West", "Egypt", 12,
                new Classroom[] { grade12[2], grade12[3], grade12[5], grade12[7], grade12[8] }, new int[] { 60, 46, 64, 50, 73 });
            Student s454 = MakeStudent("Bonnie", "Pearson", "Russia", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[6] }, new int[] { 82, 96, 77 });
            Student s455 = MakeStudent("Dana", "Brooks", "Russia", 11,
                new Classroom[] { grade11[2], grade11[4], grade11[7] }, new int[] { 51, 66, 59 });
            Student s456 = MakeStudent("Gavin", "James", "Canada", 11,
                new Classroom[] { grade11[1] }, new int[] { 51 });
            Student s457 = MakeStudent("Paula", "Robinson", "Canada", 12,
                new Classroom[] { grade12[9] }, new int[] { 50 });
            Student s458 = MakeStudent("Teresa", "Rivera", "Turkey", 12,
                new Classroom[] { grade12[0], grade12[1], grade12[9], grade12[11] }, new int[] { 68, 50, 71, 55 });
            Student s459 = MakeStudent("Andre", "Prescott", "United States", 12,
                new Classroom[] { grade12[7], grade12[10] }, new int[] { 64, 50 });
            Student s460 = MakeStudent("Kristen", "Moore", "Japan", 10,
                new Classroom[] { grade10[2] }, new int[] { 66 });
            Student s461 = MakeStudent("Bernice", "Chapman", "Iran", 11,
                new Classroom[] { grade11[2], grade11[4], grade11[11] }, new int[] { 56, 92, 67 });
            Student s462 = MakeStudent("Roland", "Bailey", "Spain", 10,
                new Classroom[] { grade10[3], grade10[4], grade10[7] }, new int[] { 44, 60, 47 });
            Student s463 = MakeStudent("Pamela", "Long", "Vietnam", 12,
                new Classroom[] { grade12[3], grade12[10] }, new int[] { 61, 57 });
            Student s464 = MakeStudent("Michelle", "Murphy", "Iran", 11,
                new Classroom[] { grade11[3], grade11[5] }, new int[] { 81, 51 });
            Student s465 = MakeStudent("Tracy", "Stanley", "United States", 12,
                new Classroom[] { grade12[0], grade12[4] }, new int[] { 49, 76 });
            Student s466 = MakeStudent("Dolores", "Moreno", "Russia", 11,
                new Classroom[] { grade11[11], grade11[12] }, new int[] { 97, 100 });
            Student s467 = MakeStudent("Ted", "Anderson", "Mexico", 10,
                new Classroom[] { grade10[0], grade10[5] }, new int[] { 88, 75 });
            Student s468 = MakeStudent("Judy", "Nguyen", "Japan", 10,
                new Classroom[] { grade10[3], grade10[6] }, new int[] { 50, 53 });
            Student s469 = MakeStudent("Tonya", "Cook", "Japan", 12,
                new Classroom[] { grade12[7] }, new int[] { 66 });
            Student s470 = MakeStudent("Lydia", "Walker", "Australia", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[9], grade10[11] }, new int[] { 88, 81, 53, 42 });
            Student s471 = MakeStudent("Daisy", "Brown", "Vietnam", 10,
                new Classroom[] { grade10[4], grade10[9] }, new int[] { 53, 77 });
            Student s472 = MakeStudent("Hazel", "Diaz", "Nigeria", 12,
                new Classroom[] { grade12[5], grade12[6], grade12[8], grade12[12] }, new int[] { 44, 72, 88, 86 });
            Student s473 = MakeStudent("Allen", "Olson", "China", 12,
                new Classroom[] { grade12[12] }, new int[] { 74 });
            Student s474 = MakeStudent("Timmothy", "Shaw", "Japan", 11,
                new Classroom[] { grade11[1], grade11[11] }, new int[] { 82, 92 });
            Student s475 = MakeStudent("Rita", "Fox", "Greece", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[8], grade12[10], grade12[12] }, new int[] { 97, 78, 96, 98, 71 });
            Student s476 = MakeStudent("Frances", "Thomas", "Vietnam", 12,
                new Classroom[] { grade12[6], grade12[7] }, new int[] { 94, 59 });
            Student s477 = MakeStudent("Clayton", "Rhodes", "England", 12,
                new Classroom[] { grade12[2], grade12[6] }, new int[] { 53, 46 });
            Student s478 = MakeStudent("Gail", "Bryant", "Japan", 11,
                new Classroom[] { grade11[1], grade11[10] }, new int[] { 66, 63 });
            Student s479 = MakeStudent("Scott", "Alvarez", "Canada", 10,
                new Classroom[] { grade10[2], grade10[7], grade10[8], grade10[9], grade10[10] }, new int[] { 58, 81, 74, 58, 84 });
            Student s480 = MakeStudent("Dave", "Green", "Greece", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[4], grade12[9], grade12[10] }, new int[] { 91, 70, 73, 58, 94 });
            Student s481 = MakeStudent("Nina", "Patterson", "United States", 10,
                new Classroom[] { grade10[0], grade10[2], grade10[7], grade10[10], grade10[12] }, new int[] { 66, 76, 96, 86, 54 });
            Student s482 = MakeStudent("Marjorie", "Morgan", "Canada", 11,
                new Classroom[] { grade11[7], grade11[12] }, new int[] { 45, 60 });
            Student s483 = MakeStudent("Billie", "Ray", "France", 11,
                new Classroom[] { grade11[8] }, new int[] { 53 });
            Student s484 = MakeStudent("Stella", "Ford", "France", 12,
                new Classroom[] { grade12[4], grade12[6], grade12[7], grade12[10], grade12[12] }, new int[] { 77, 94, 45, 92, 79 });
            Student s485 = MakeStudent("Juanita", "Jones", "Greece", 11,
                new Classroom[] { grade11[3], grade11[5], grade11[12] }, new int[] { 86, 75, 44 });
            Student s486 = MakeStudent("Kitty", "Snyder", "France", 10,
                new Classroom[] { grade10[9], grade10[12] }, new int[] { 99, 55 });
            Student s487 = MakeStudent("Oscar", "Holland", "Egypt", 11,
                new Classroom[] { grade11[0], grade11[6], grade11[7] }, new int[] { 81, 40, 49 });
            Student s488 = MakeStudent("Riley", "Silva", "Spain", 12,
                new Classroom[] { grade12[0], grade12[6] }, new int[] { 55, 77 });
            Student s489 = MakeStudent("Ann", "Mason", "Greece", 12,
                new Classroom[] { grade12[1], grade12[2], grade12[8], grade12[10], grade12[11] }, new int[] { 96, 70, 51, 93, 52 });
            Student s490 = MakeStudent("Dustin", "Fleming", "Spain", 12,
                new Classroom[] { grade12[5], grade12[9] }, new int[] { 99, 67 });
            Student s491 = MakeStudent("Billie", "Lynch", "Canada", 12,
                new Classroom[] { grade12[3], grade12[6], grade12[7], grade12[9], grade12[12] }, new int[] { 67, 66, 57, 87, 80 });
            Student s492 = MakeStudent("Wilma", "Snyder", "England", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[8], grade11[11], grade11[12] }, new int[] { 54, 76, 40, 61, 69 });
            Student s493 = MakeStudent("Jessie", "Perkins", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[11], grade11[12] }, new int[] { 60, 83, 44, 48 });
            Student s494 = MakeStudent("Holly", "Lucas", "England", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[3], grade10[8], grade10[12] }, new int[] { 99, 60, 82, 69, 65 });
            Student s495 = MakeStudent("Holly", "Spencer", "England", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[3], grade11[4] }, new int[] { 69, 77, 40, 42 });
            Student s496 = MakeStudent("Tammy", "Horton", "Canada", 10,
                new Classroom[] { grade10[6] }, new int[] { 73 });
            Student s497 = MakeStudent("Ethan", "Brown", "Japan", 10,
                new Classroom[] { grade10[4], grade10[8] }, new int[] { 83, 84 });
            Student s498 = MakeStudent("Yvonne", "Neal", "Egypt", 10,
                new Classroom[] { grade10[9] }, new int[] { 70 });
            Student s499 = MakeStudent("Tamara", "Flores", "Canada", 11,
                new Classroom[] { grade11[3], grade11[5], grade11[6], grade11[9] }, new int[] { 70, 85, 51, 67 });
            #endregion Students400-499
        }

        private Classroom MakeClassroom(Course course, Teacher teacher)
        {
            Classroom result = new(course, teacher);
            Classrooms.Add(result);
            course.Classrooms.Add(result);
            teacher.Classrooms.Add(result);
            return result;
        }

        private Student MakeStudent(string fName, string lName, string nation, int grade, Classroom[] classes, int[] grades)
        {
            if (classes.Length != grades.Length)
            {
                throw new Exception("Grade-Class data size Mismatch");
            }

            Student newStudent = new(firstName: fName, lastName: lName, nationality: nation, grade: grade);
            Students.Add(newStudent);

            for (int i = 0; i < classes.Length; i++)
            {
                ClassroomStudent cs = new(classes[i], newStudent, grades[i]);
                newStudent.ClassroomStudents.Add(cs);
                classes[i].ClassroomStudents.Add(cs);
                ClassroomStudents.Add(cs);
            }

            return newStudent;
        }
    }
}
