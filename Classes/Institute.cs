using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    internal class Institute
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

        public void InitializeData()
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
            Student s000 = MakeStudent("Darrell", "Rivera", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[11], grade12[2], grade12[4], grade12[0] }, new int[] { 94, 60, 81, 76, 76 });
            Student s001 = MakeStudent("Joel", "Gomez", "Mexico", 10,
                new Classroom[] { grade10[11], grade10[10] }, new int[] { 55, 47 });
            Student s002 = MakeStudent("Amanda", "Morris", "Vietnam", 11,
                new Classroom[] { grade11[0] }, new int[] { 70 });
            Student s003 = MakeStudent("Cody", "Richards", "Greece", 12,
                new Classroom[] { grade12[10], grade12[10], grade12[8], grade12[9], grade12[3] }, new int[] { 78, 72, 67, 85, 93 });
            Student s004 = MakeStudent("Earl", "Perez", "France", 11,
                new Classroom[] { grade11[12] }, new int[] { 64 });
            Student s005 = MakeStudent("Daisy", "Bell", "France", 12,
                new Classroom[] { grade12[5], grade12[2], grade12[5], grade12[10] }, new int[] { 80, 50, 52, 91 });
            Student s006 = MakeStudent("Shelly", "Hernandez", "Japan", 11,
                new Classroom[] { grade11[0], grade11[9] }, new int[] { 49, 100 });
            Student s007 = MakeStudent("Mabel", "Johnston", "Greece", 10,
                new Classroom[] { grade10[10], grade10[6], grade10[10], grade10[6] }, new int[] { 40, 79, 83, 77 });
            Student s008 = MakeStudent("Brent", "Miles", "Mexico", 10,
                new Classroom[] { grade10[12], grade10[5], grade10[1] }, new int[] { 59, 50, 74 });
            Student s009 = MakeStudent("Renee", "Beck", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[11], grade12[9], grade12[9] }, new int[] { 93, 72, 71, 96 });
            Student s010 = MakeStudent("Daryl", "Nguyen", "Iran", 10,
                new Classroom[] { grade10[3] }, new int[] { 78 });
            Student s011 = MakeStudent("Christina", "Fletcher", "South Korea", 12,
                new Classroom[] { grade12[7], grade12[0], grade12[5] }, new int[] { 74, 66, 76 });
            Student s012 = MakeStudent("Mia", "Lawrence", "China", 10,
                new Classroom[] { grade10[1] }, new int[] { 67 });
            Student s013 = MakeStudent("Reginald", "Wells", "Vietnam", 11,
                new Classroom[] { grade11[7] }, new int[] { 71 });
            Student s014 = MakeStudent("Bessie", "Burton", "Iran", 12,
                new Classroom[] { grade12[6], grade12[9], grade12[11] }, new int[] { 75, 73, 89 });
            Student s015 = MakeStudent("Allison", "Jensen", "France", 11,
                new Classroom[] { grade11[3] }, new int[] { 88 });
            Student s016 = MakeStudent("Everett", "James", "Vietnam", 11,
                new Classroom[] { grade11[10], grade11[9], grade11[6], grade11[1], grade11[7] }, new int[] { 55, 53, 41, 98, 52 });
            Student s017 = MakeStudent("Dylan", "Thomas", "Iran", 11,
                new Classroom[] { grade11[10], grade11[5], grade11[12], grade11[6], grade11[2] }, new int[] { 90, 52, 87, 75, 50 });
            Student s018 = MakeStudent("Jessica", "Green", "Iran", 12,
                new Classroom[] { grade12[1], grade12[1], grade12[1] }, new int[] { 93, 46, 79 });
            Student s019 = MakeStudent("Javier", "Owens", "China", 10,
                new Classroom[] { grade10[6], grade10[11], grade10[12], grade10[2], grade10[11] }, new int[] { 48, 69, 45, 59, 81 });
            Student s020 = MakeStudent("Sara", "Riley", "Vietnam", 11,
                new Classroom[] { grade11[3], grade11[6], grade11[9] }, new int[] { 55, 90, 96 });
            Student s021 = MakeStudent("Luke", "Simmmons", "Spain", 12,
                new Classroom[] { grade12[6], grade12[6], grade12[11], grade12[10] }, new int[] { 64, 92, 48, 70 });
            Student s022 = MakeStudent("Mia", "Lucas", "Vietnam", 10,
                new Classroom[] { grade10[12], grade10[0], grade10[11], grade10[9], grade10[3] }, new int[] { 93, 59, 78, 89, 72 });
            Student s023 = MakeStudent("Bruce", "Frazier", "Spain", 12,
                new Classroom[] { grade12[3], grade12[0], grade12[5] }, new int[] { 47, 54, 44 });
            Student s024 = MakeStudent("Logan", "Arnold", "China", 11,
                new Classroom[] { grade11[0], grade11[6] }, new int[] { 67, 95 });
            Student s025 = MakeStudent("Alexis", "Morales", "Mexico", 11,
                new Classroom[] { grade11[8], grade11[4] }, new int[] { 43, 76 });
            Student s026 = MakeStudent("Joan", "Scott", "Australia", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[8], grade11[2] }, new int[] { 78, 76, 78, 74 });
            Student s027 = MakeStudent("Cecil", "Thomas", "Vietnam", 10,
                new Classroom[] { grade10[8], grade10[12], grade10[12], grade10[12] }, new int[] { 73, 58, 56, 83 });
            Student s028 = MakeStudent("Same", "Foster", "United States", 11,
                new Classroom[] { grade11[4], grade11[9], grade11[4], grade11[9], grade11[12] }, new int[] { 76, 75, 83, 75, 56 });
            Student s029 = MakeStudent("Tyrone", "Rose", "Mexico", 10,
                new Classroom[] { grade10[3], grade10[9], grade10[4], grade10[8] }, new int[] { 86, 96, 67, 86 });
            Student s030 = MakeStudent("Eva", "Kim", "Canada", 11,
                new Classroom[] { grade11[2], grade11[11], grade11[1], grade11[2], grade11[5] }, new int[] { 48, 81, 73, 58, 98 });
            Student s031 = MakeStudent("Shelly", "Fuller", "Japan", 11,
                new Classroom[] { grade11[3] }, new int[] { 44 });
            Student s032 = MakeStudent("Dora", "Hale", "Canada", 11,
                new Classroom[] { grade11[5], grade11[9], grade11[2], grade11[2] }, new int[] { 72, 79, 69, 79 });
            Student s033 = MakeStudent("Sonia", "Ramos", "England", 10,
                new Classroom[] { grade10[5], grade10[0], grade10[9] }, new int[] { 76, 71, 79 });
            Student s034 = MakeStudent("Elizabeth", "Ellis", "Greece", 10,
                new Classroom[] { grade10[12], grade10[12], grade10[12] }, new int[] { 68, 63, 81 });
            Student s035 = MakeStudent("Mattie", "Riley", "Egypt", 10,
                new Classroom[] { grade10[7], grade10[10], grade10[5] }, new int[] { 68, 73, 77 });
            Student s036 = MakeStudent("Brian", "Morgan", "England", 11,
                new Classroom[] { grade11[2], grade11[11] }, new int[] { 67, 100 });
            Student s037 = MakeStudent("Joel", "Taylor", "Iran", 11,
                new Classroom[] { grade11[3], grade11[0] }, new int[] { 69, 72 });
            Student s038 = MakeStudent("Ashley", "Miles", "Nigeria", 10,
                new Classroom[] { grade10[3], grade10[0], grade10[0] }, new int[] { 93, 76, 46 });
            Student s039 = MakeStudent("Yolanda", "Hansen", "England", 11,
                new Classroom[] { grade11[12], grade11[12] }, new int[] { 95, 41 });
            Student s040 = MakeStudent("Charlie", "Shaw", "England", 11,
                new Classroom[] { grade11[7], grade11[4], grade11[3], grade11[4] }, new int[] { 80, 40, 77, 66 });
            Student s041 = MakeStudent("Alicia", "Lopez", "Greece", 10,
                new Classroom[] { grade10[12] }, new int[] { 44 });
            Student s042 = MakeStudent("Krin", "Ferguson", "England", 10,
                new Classroom[] { grade10[11], grade10[9], grade10[0], grade10[5], grade10[3] }, new int[] { 51, 66, 85, 88, 60 });
            Student s043 = MakeStudent("Gabriella", "Moreno", "Canada", 11,
                new Classroom[] { grade11[7], grade11[4], grade11[0] }, new int[] { 54, 71, 73 });
            Student s044 = MakeStudent("Ritthy", "Hale", "Turkey", 12,
                new Classroom[] { grade12[12], grade12[1], grade12[12], grade12[11], grade12[4] }, new int[] { 65, 40, 94, 80, 77 });
            Student s045 = MakeStudent("Emma", "Murray", "Turkey", 11,
                new Classroom[] { grade11[1], grade11[6], grade11[4], grade11[11], grade11[3] }, new int[] { 91, 95, 78, 69, 94 });
            Student s046 = MakeStudent("Marjorie", "King", "England", 10,
                new Classroom[] { grade10[8], grade10[3], grade10[9], grade10[10], grade10[4] }, new int[] { 61, 60, 56, 66, 53 });
            Student s047 = MakeStudent("Marie", "Lawson", "Egypt", 12,
                new Classroom[] { grade12[10], grade12[11], grade12[5], grade12[5], grade12[7] }, new int[] { 82, 80, 67, 67, 50 });
            Student s048 = MakeStudent("Jamie", "Gutierrez", "England", 12,
                new Classroom[] { grade12[9], grade12[3], grade12[11], grade12[0] }, new int[] { 89, 95, 45, 79 });
            Student s049 = MakeStudent("Ben", "Fernandez", "Turkey", 10,
                new Classroom[] { grade10[6], grade10[11] }, new int[] { 92, 98 });
            Student s050 = MakeStudent("Lauren", "Lynch", "England", 12,
                new Classroom[] { grade12[8] }, new int[] { 79 });
            Student s051 = MakeStudent("Elsie", "Lawrence", "Nigeria", 10,
                new Classroom[] { grade10[2], grade10[8], grade10[11], grade10[0] }, new int[] { 82, 50, 91, 48 });
            Student s052 = MakeStudent("Norma", "Johnston", "Egypt", 11,
                new Classroom[] { grade11[11], grade11[7], grade11[12], grade11[9] }, new int[] { 52, 74, 52, 54 });
            Student s053 = MakeStudent("Lillian", "Barrett", "France", 11,
                new Classroom[] { grade11[10] }, new int[] { 88 });
            Student s054 = MakeStudent("Ann", "Woods", "Iran", 12,
                new Classroom[] { grade12[5], grade12[11], grade12[3] }, new int[] { 84, 47, 71 });
            Student s055 = MakeStudent("Corey", "Daniels", "England", 12,
                new Classroom[] { grade12[7], grade12[0], grade12[9], grade12[1] }, new int[] { 79, 76, 68, 74 });
            Student s056 = MakeStudent("Clara", "Holland", "Egypt", 12,
                new Classroom[] { grade12[6], grade12[8] }, new int[] { 67, 82 });
            Student s057 = MakeStudent("Elsie", "Wallace", "England", 10,
                new Classroom[] { grade10[9], grade10[0], grade10[3], grade10[0], grade10[7] }, new int[] { 87, 44, 43, 98, 42 });
            Student s058 = MakeStudent("Eli", "Larson", "Spain", 11,
                new Classroom[] { grade11[9], grade11[8], grade11[0], grade11[4], grade11[1] }, new int[] { 93, 92, 83, 72, 76 });
            Student s059 = MakeStudent("James", "Davis", "Greece", 11,
                new Classroom[] { grade11[9], grade11[9], grade11[4] }, new int[] { 64, 97, 64 });
            Student s060 = MakeStudent("Olivia", "Crawford", "Vietnam", 12,
                new Classroom[] { grade12[1] }, new int[] { 49 });
            Student s061 = MakeStudent("Jack", "Watts", "France", 10,
                new Classroom[] { grade10[3], grade10[7], grade10[11], grade10[0], grade10[4] }, new int[] { 67, 70, 74, 59, 50 });
            Student s062 = MakeStudent("Walter", "Fernandez", "France", 11,
                new Classroom[] { grade11[11], grade11[1], grade11[1], grade11[10] }, new int[] { 77, 78, 64, 45 });
            Student s063 = MakeStudent("Phillip", "Barrett", "Mexico", 10,
                new Classroom[] { grade10[11], grade10[8], grade10[9], grade10[5], grade10[1] }, new int[] { 58, 44, 50, 62, 99 });
            Student s064 = MakeStudent("Ida", "Ortiz", "Nigeria", 12,
                new Classroom[] { grade12[2], grade12[6], grade12[12], grade12[7] }, new int[] { 74, 50, 65, 55 });
            Student s065 = MakeStudent("Gabriel", "Harrison", "United States", 11,
                new Classroom[] { grade11[0], grade11[9], grade11[4], grade11[10] }, new int[] { 73, 55, 55, 54 });
            Student s066 = MakeStudent("Jennie", "Hanson", "Greece", 11,
                new Classroom[] { grade11[7], grade11[6], grade11[2], grade11[1], grade11[2] }, new int[] { 99, 47, 61, 41, 56 });
            Student s067 = MakeStudent("Letitia", "Henry", "Russia", 10,
                new Classroom[] { grade10[5], grade10[1], grade10[6], grade10[1] }, new int[] { 78, 56, 81, 47 });
            Student s068 = MakeStudent("Jim", "Jordan", "Russia", 11,
                new Classroom[] { grade11[10] }, new int[] { 55 });
            Student s069 = MakeStudent("Russell", "Roberts", "Russia", 11,
                new Classroom[] { grade11[11] }, new int[] { 45 });
            Student s070 = MakeStudent("Courtney", "Garza", "Iran", 10,
                new Classroom[] { grade10[2] }, new int[] { 43 });
            Student s071 = MakeStudent("Darren", "Schmidt", "China", 12,
                new Classroom[] { grade12[6], grade12[8], grade12[10], grade12[6] }, new int[] { 79, 44, 78, 100 });
            Student s072 = MakeStudent("Edgar", "Cook", "Russia", 12,
                new Classroom[] { grade12[12], grade12[8], grade12[1], grade12[0] }, new int[] { 48, 57, 55, 62 });
            Student s073 = MakeStudent("Beverly", "Gardner", "Nigeria", 11,
                new Classroom[] { grade11[4] }, new int[] { 85 });
            Student s074 = MakeStudent("Lewis", "Patterson", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[3], grade10[5], grade10[8], grade10[5] }, new int[] { 71, 62, 64, 49, 45 });
            Student s075 = MakeStudent("Levi", "Peck", "Spain", 12,
                new Classroom[] { grade12[3], grade12[7], grade12[10] }, new int[] { 88, 56, 73 });
            Student s076 = MakeStudent("Eleanor", "Garza", "Turkey", 12,
                new Classroom[] { grade12[1] }, new int[] { 62 });
            Student s077 = MakeStudent("Joan", "Grant", "United States", 10,
                new Classroom[] { grade10[12], grade10[5], grade10[0] }, new int[] { 46, 44, 69 });
            Student s078 = MakeStudent("Wade", "Lucas", "Japan", 11,
                new Classroom[] { grade11[7], grade11[10], grade11[9], grade11[2], grade11[8] }, new int[] { 56, 93, 68, 41, 84 });
            Student s079 = MakeStudent("Brennan", "Simmmons", "Russia", 11,
                new Classroom[] { grade11[8], grade11[0] }, new int[] { 52, 51 });
            Student s080 = MakeStudent("Alex", "Ross", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[5] }, new int[] { 55, 85 });
            Student s081 = MakeStudent("Eleanor", "Butler", "Vietnam", 10,
                new Classroom[] { grade10[4] }, new int[] { 82 });
            Student s082 = MakeStudent("Claude", "Meyer", "Spain", 11,
                new Classroom[] { grade11[5], grade11[2], grade11[12] }, new int[] { 49, 48, 68 });
            Student s083 = MakeStudent("Ross", "Williams", "Egypt", 11,
                new Classroom[] { grade11[8], grade11[8], grade11[2], grade11[7] }, new int[] { 42, 87, 70, 40 });
            Student s084 = MakeStudent("Gwendolyn", "Grant", "Mexico", 11,
                new Classroom[] { grade11[5], grade11[3], grade11[5], grade11[10] }, new int[] { 69, 100, 42, 82 });
            Student s085 = MakeStudent("Donald", "Martinez", "Australia", 11,
                new Classroom[] { grade11[9] }, new int[] { 83 });
            Student s086 = MakeStudent("Mario", "Bennett", "China", 10,
                new Classroom[] { grade10[5], grade10[10] }, new int[] { 100, 54 });
            Student s087 = MakeStudent("Clarence", "Johnston", "United States", 11,
                new Classroom[] { grade11[11], grade11[3], grade11[9] }, new int[] { 84, 64, 50 });
            Student s088 = MakeStudent("Maurice", "Adams", "Canada", 12,
                new Classroom[] { grade12[6], grade12[8] }, new int[] { 64, 91 });
            Student s089 = MakeStudent("Herbert", "Dean", "Iran", 12,
                new Classroom[] { grade12[1], grade12[5], grade12[9], grade12[12], grade12[3] }, new int[] { 70, 45, 99, 53, 83 });
            Student s090 = MakeStudent("Lewis", "Lewis", "United States", 10,
                new Classroom[] { grade10[11] }, new int[] { 78 });
            Student s091 = MakeStudent("Megan", "Meyer", "France", 11,
                new Classroom[] { grade11[7], grade11[4], grade11[4] }, new int[] { 67, 96, 72 });
            Student s092 = MakeStudent("Ricardo", "Holland", "China", 11,
                new Classroom[] { grade11[7], grade11[5], grade11[11], grade11[8], grade11[8] }, new int[] { 82, 90, 55, 79, 56 });
            Student s093 = MakeStudent("Edgar", "King", "Turkey", 10,
                new Classroom[] { grade10[6] }, new int[] { 100 });
            Student s094 = MakeStudent("Lori", "Silva", "Nigeria", 12,
                new Classroom[] { grade12[3], grade12[0], grade12[4], grade12[6], grade12[12] }, new int[] { 66, 62, 89, 67, 73 });
            Student s095 = MakeStudent("Ted", "Rhodes", "Mexico", 10,
                new Classroom[] { grade10[0] }, new int[] { 41 });
            Student s096 = MakeStudent("Walter", "Duncan", "South Korea", 11,
                new Classroom[] { grade11[0], grade11[1], grade11[6] }, new int[] { 85, 40, 69 });
            Student s097 = MakeStudent("Alma", "Fletcher", "South Korea", 12,
                new Classroom[] { grade12[4], grade12[6] }, new int[] { 50, 89 });
            Student s098 = MakeStudent("Lillie", "Harvey", "Spain", 10,
                new Classroom[] { grade10[7], grade10[12], grade10[8], grade10[10], grade10[9] }, new int[] { 100, 91, 58, 91, 56 });
            Student s099 = MakeStudent("Dan", "Williamson", "Nigeria", 11,
                new Classroom[] { grade11[3], grade11[2], grade11[6], grade11[9], grade11[4] }, new int[] { 64, 92, 51, 92, 92 });
            #endregion Students000-099

            #region Students100-199
            Student s100 = MakeStudent("June", "Anderson", "Canada", 10,
                new Classroom[] { grade10[8] }, new int[] { 89 });
            Student s101 = MakeStudent("Riley", "Graves", "France", 12,
                new Classroom[] { grade12[11], grade12[5], grade12[11], grade12[11], grade12[8] }, new int[] { 95, 53, 71, 43, 86 });
            Student s102 = MakeStudent("Joe", "Smith", "United States", 10,
                new Classroom[] { grade10[0], grade10[12], grade10[3], grade10[4], grade10[10] }, new int[] { 84, 59, 80, 74, 95 });
            Student s103 = MakeStudent("Rick", "Franklin", "United States", 10,
                new Classroom[] { grade10[8], grade10[7] }, new int[] { 64, 41 });
            Student s104 = MakeStudent("Brandy", "Kennedy", "Russia", 11,
                new Classroom[] { grade11[2], grade11[0], grade11[9] }, new int[] { 66, 89, 91 });
            Student s105 = MakeStudent("Yvonne", "Frazier", "Spain", 10,
                new Classroom[] { grade10[10], grade10[5] }, new int[] { 43, 82 });
            Student s106 = MakeStudent("Dustin", "Lynch", "Canada", 11,
                new Classroom[] { grade11[12], grade11[2], grade11[11], grade11[12] }, new int[] { 69, 82, 70, 90 });
            Student s107 = MakeStudent("Ron", "Lawrence", "Turkey", 10,
                new Classroom[] { grade10[12], grade10[8] }, new int[] { 75, 77 });
            Student s108 = MakeStudent("Felicia", "Wood", "Vietnam", 11,
                new Classroom[] { grade11[5], grade11[3] }, new int[] { 90, 90 });
            Student s109 = MakeStudent("Morris", "Robertson", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[11] }, new int[] { 62, 74 });
            Student s110 = MakeStudent("Luke", "Henry", "Iran", 10,
                new Classroom[] { grade10[5] }, new int[] { 74 });
            Student s111 = MakeStudent("Derek", "Butler", "United States", 11,
                new Classroom[] { grade11[9], grade11[6], grade11[6], grade11[5], grade11[5] }, new int[] { 53, 85, 82, 82, 72 });
            Student s112 = MakeStudent("Louella", "Palmer", "Mexico", 11,
                new Classroom[] { grade11[8], grade11[6], grade11[0], grade11[8] }, new int[] { 57, 86, 91, 61 });
            Student s113 = MakeStudent("Marilyn", "Payne", "South Korea", 10,
                new Classroom[] { grade10[4] }, new int[] { 49 });
            Student s114 = MakeStudent("Jonathan", "Black", "Turkey", 11,
                new Classroom[] { grade11[11], grade11[12], grade11[5], grade11[3] }, new int[] { 92, 73, 58, 96 });
            Student s115 = MakeStudent("Kenzi", "Daniels", "Canada", 11,
                new Classroom[] { grade11[4], grade11[4], grade11[0], grade11[8], grade11[1] }, new int[] { 50, 56, 85, 65, 92 });
            Student s116 = MakeStudent("Tanya", "Rhodes", "Canada", 10,
                new Classroom[] { grade10[9], grade10[10], grade10[1], grade10[12] }, new int[] { 88, 92, 78, 87 });
            Student s117 = MakeStudent("Duane", "Morrison", "Turkey", 10,
                new Classroom[] { grade10[0], grade10[6], grade10[6], grade10[12], grade10[11] }, new int[] { 79, 40, 43, 55, 64 });
            Student s118 = MakeStudent("Mitchell", "Foster", "Iran", 10,
                new Classroom[] { grade10[10] }, new int[] { 64 });
            Student s119 = MakeStudent("Virgil", "Cunningham", "Russia", 10,
                new Classroom[] { grade10[10], grade10[7] }, new int[] { 43, 50 });
            Student s120 = MakeStudent("Nathaniel", "Cox", "Australia", 11,
                new Classroom[] { grade11[3], grade11[3], grade11[11], grade11[4] }, new int[] { 96, 67, 60, 59 });
            Student s121 = MakeStudent("Crystal", "Dunn", "Australia", 11,
                new Classroom[] { grade11[0], grade11[1] }, new int[] { 56, 88 });
            Student s122 = MakeStudent("Larry", "Wood", "South Korea", 10,
                new Classroom[] { grade10[1], grade10[8], grade10[7] }, new int[] { 61, 93, 74 });
            Student s123 = MakeStudent("Misty", "Gordon", "Egypt", 10,
                new Classroom[] { grade10[7] }, new int[] { 59 });
            Student s124 = MakeStudent("Audrey", "Hill", "Greece", 11,
                new Classroom[] { grade11[11] }, new int[] { 51 });
            Student s125 = MakeStudent("Maureen", "Richards", "United States", 11,
                new Classroom[] { grade11[5] }, new int[] { 97 });
            Student s126 = MakeStudent("Eleanor", "Bryant", "United States", 10,
                new Classroom[] { grade10[4] }, new int[] { 68 });
            Student s127 = MakeStudent("Herminia", "Willis", "Australia", 11,
                new Classroom[] { grade11[2], grade11[12] }, new int[] { 53, 81 });
            Student s128 = MakeStudent("Warren", "Ryan", "Mexico", 11,
                new Classroom[] { grade11[1], grade11[9], grade11[12], grade11[11] }, new int[] { 99, 72, 86, 70 });
            Student s129 = MakeStudent("Joanne", "Morris", "Nigeria", 11,
                new Classroom[] { grade11[1] }, new int[] { 73 });
            Student s130 = MakeStudent("Harry", "Taylor", "Egypt", 10,
                new Classroom[] { grade10[2], grade10[7], grade10[5], grade10[1], grade10[2] }, new int[] { 64, 88, 92, 92, 87 });
            Student s131 = MakeStudent("Violet", "Shelton", "France", 12,
                new Classroom[] { grade12[12], grade12[3] }, new int[] { 53, 47 });
            Student s132 = MakeStudent("Felecia", "Dean", "Turkey", 11,
                new Classroom[] { grade11[7], grade11[7] }, new int[] { 40, 90 });
            Student s133 = MakeStudent("Martin", "Young", "Australia", 12,
                new Classroom[] { grade12[2], grade12[9] }, new int[] { 92, 87 });
            Student s134 = MakeStudent("Andrew", "Murphy", "South Korea", 11,
                new Classroom[] { grade11[4], grade11[6], grade11[10], grade11[7] }, new int[] { 73, 47, 44, 75 });
            Student s135 = MakeStudent("Gertrude", "Richardson", "Australia", 11,
                new Classroom[] { grade11[9] }, new int[] { 40 });
            Student s136 = MakeStudent("Theresa", "Rivera", "Vietnam", 11,
                new Classroom[] { grade11[1], grade11[10], grade11[6], grade11[12] }, new int[] { 95, 51, 55, 80 });
            Student s137 = MakeStudent("Amelia", "Simpson", "Australia", 10,
                new Classroom[] { grade10[4], grade10[7], grade10[8], grade10[1] }, new int[] { 61, 94, 61, 88 });
            Student s138 = MakeStudent("Brennan", "Bell", "Egypt", 10,
                new Classroom[] { grade10[6], grade10[2], grade10[8], grade10[10] }, new int[] { 66, 99, 79, 77 });
            Student s139 = MakeStudent("Leon", "George", "Iran", 12,
                new Classroom[] { grade12[6], grade12[2], grade12[12], grade12[3] }, new int[] { 82, 59, 96, 80 });
            Student s140 = MakeStudent("Austin", "Lowe", "United States", 10,
                new Classroom[] { grade10[6], grade10[1], grade10[0] }, new int[] { 54, 62, 51 });
            Student s141 = MakeStudent("Leta", "Watkins", "Japan", 11,
                new Classroom[] { grade11[11], grade11[6], grade11[9], grade11[2], grade11[12] }, new int[] { 71, 45, 77, 92, 41 });
            Student s142 = MakeStudent("Rhonda", "Jenkins", "Turkey", 11,
                new Classroom[] { grade11[6], grade11[9], grade11[7], grade11[5] }, new int[] { 72, 52, 92, 74 });
            Student s143 = MakeStudent("Adrian", "Sims", "Greece", 12,
                new Classroom[] { grade12[11] }, new int[] { 69 });
            Student s144 = MakeStudent("Ellen", "Steeves ", "Russia", 12,
                new Classroom[] { grade12[7], grade12[7], grade12[9], grade12[11] }, new int[] { 45, 53, 91, 52 });
            Student s145 = MakeStudent("Michelle", "Jacobs", "United States", 10,
                new Classroom[] { grade10[4] }, new int[] { 74 });
            Student s146 = MakeStudent("Marlene", "Myers", "Canada", 11,
                new Classroom[] { grade11[3], grade11[1], grade11[2], grade11[8] }, new int[] { 59, 57, 63, 91 });
            Student s147 = MakeStudent("Alfred", "Stephens", "England", 12,
                new Classroom[] { grade12[1], grade12[4], grade12[2], grade12[3], grade12[10] }, new int[] { 68, 56, 97, 89, 99 });
            Student s148 = MakeStudent("Alfredo", "James", "Iran", 10,
                new Classroom[] { grade10[7], grade10[8] }, new int[] { 70, 42 });
            Student s149 = MakeStudent("Vanessa", "Hudson", "Nigeria", 12,
                new Classroom[] { grade12[10], grade12[6], grade12[6] }, new int[] { 69, 77, 82 });
            Student s150 = MakeStudent("Theodore", "Fernandez", "Vietnam", 12,
                new Classroom[] { grade12[8], grade12[6] }, new int[] { 92, 96 });
            Student s151 = MakeStudent("Lillian", "Mitchell", "Greece", 10,
                new Classroom[] { grade10[12], grade10[2], grade10[8], grade10[4], grade10[2] }, new int[] { 94, 83, 83, 73, 46 });
            Student s152 = MakeStudent("Jeffrey", "Mendoza", "China", 10,
                new Classroom[] { grade10[10], grade10[7], grade10[4], grade10[8] }, new int[] { 89, 74, 40, 73 });
            Student s153 = MakeStudent("Catherine", "Obrien", "Vietnam", 12,
                new Classroom[] { grade12[7], grade12[7], grade12[5], grade12[10] }, new int[] { 74, 96, 48, 82 });
            Student s154 = MakeStudent("Meghan", "Mendoza", "Iran", 11,
                new Classroom[] { grade11[9] }, new int[] { 54 });
            Student s155 = MakeStudent("Cody", "Rodriguez", "Nigeria", 11,
                new Classroom[] { grade11[3] }, new int[] { 91 });
            Student s156 = MakeStudent("Terrence", "Simmmons", "Nigeria", 11,
                new Classroom[] { grade11[9], grade11[4], grade11[0], grade11[1] }, new int[] { 42, 48, 76, 43 });
            Student s157 = MakeStudent("Bernard", "Brooks", "Egypt", 10,
                new Classroom[] { grade10[7], grade10[1], grade10[3], grade10[9], grade10[12] }, new int[] { 100, 71, 96, 55, 85 });
            Student s158 = MakeStudent("Bob", "Berry", "Vietnam", 12,
                new Classroom[] { grade12[10] }, new int[] { 47 });
            Student s159 = MakeStudent("Nelson", "Crawford", "France", 11,
                new Classroom[] { grade11[8], grade11[9], grade11[8], grade11[4] }, new int[] { 78, 67, 95, 80 });
            Student s160 = MakeStudent("Frances", "Frazier", "South Korea", 11,
                new Classroom[] { grade11[5], grade11[0], grade11[12], grade11[12] }, new int[] { 49, 45, 64, 76 });
            Student s161 = MakeStudent("Jo", "Gray", "England", 11,
                new Classroom[] { grade11[7], grade11[9], grade11[1], grade11[7] }, new int[] { 59, 63, 91, 66 });
            Student s162 = MakeStudent("April", "Richards", "China", 11,
                new Classroom[] { grade11[10], grade11[8] }, new int[] { 55, 91 });
            Student s163 = MakeStudent("Madison", "Davis", "Egypt", 10,
                new Classroom[] { grade10[7] }, new int[] { 67 });
            Student s164 = MakeStudent("Edward", "Gibson", "United States", 11,
                new Classroom[] { grade11[10], grade11[12], grade11[4] }, new int[] { 60, 95, 48 });
            Student s165 = MakeStudent("Johnny", "Hudson", "Turkey", 12,
                new Classroom[] { grade12[4], grade12[11] }, new int[] { 67, 79 });
            Student s166 = MakeStudent("Gwendolyn", "Fleming", "Spain", 12,
                new Classroom[] { grade12[12], grade12[9] }, new int[] { 55, 93 });
            Student s167 = MakeStudent("Justin", "Barrett", "Japan", 12,
                new Classroom[] { grade12[12], grade12[8] }, new int[] { 68, 81 });
            Student s168 = MakeStudent("Sara", "Wade", "Iran", 12,
                new Classroom[] { grade12[11], grade12[10], grade12[3] }, new int[] { 46, 57, 67 });
            Student s169 = MakeStudent("Brandie", "Roberts", "Spain", 10,
                new Classroom[] { grade10[2], grade10[4], grade10[4], grade10[9], grade10[6] }, new int[] { 92, 66, 99, 79, 55 });
            Student s170 = MakeStudent("Jennie", "Ruiz", "England", 11,
                new Classroom[] { grade11[8], grade11[2] }, new int[] { 98, 75 });
            Student s171 = MakeStudent("Ralph", "Vargas", "Canada", 10,
                new Classroom[] { grade10[8], grade10[10], grade10[3], grade10[6], grade10[10] }, new int[] { 87, 40, 52, 45, 98 });
            Student s172 = MakeStudent("Stephen", "Stevens", "Egypt", 10,
                new Classroom[] { grade10[5], grade10[4], grade10[6], grade10[7] }, new int[] { 51, 99, 99, 74 });
            Student s173 = MakeStudent("Courtney", "Taylor", "Spain", 12,
                new Classroom[] { grade12[1], grade12[6], grade12[8], grade12[4] }, new int[] { 53, 64, 50, 57 });
            Student s174 = MakeStudent("Juan", "Rose", "Greece", 10,
                new Classroom[] { grade10[2], grade10[9], grade10[1], grade10[4], grade10[8] }, new int[] { 88, 48, 56, 82, 86 });
            Student s175 = MakeStudent("Jill", "Lopez", "South Korea", 10,
                new Classroom[] { grade10[6], grade10[5], grade10[12], grade10[6], grade10[0] }, new int[] { 98, 61, 56, 55, 93 });
            Student s176 = MakeStudent("Lester", "Foster", "Spain", 10,
                new Classroom[] { grade10[6] }, new int[] { 95 });
            Student s177 = MakeStudent("Carmen", "Cox", "Canada", 11,
                new Classroom[] { grade11[4], grade11[12] }, new int[] { 81, 57 });
            Student s178 = MakeStudent("Devon", "Rodriguez", "Greece", 11,
                new Classroom[] { grade11[2], grade11[7] }, new int[] { 81, 76 });
            Student s179 = MakeStudent("Debra", "Moore", "China", 11,
                new Classroom[] { grade11[11], grade11[6], grade11[7], grade11[4] }, new int[] { 55, 90, 51, 73 });
            Student s180 = MakeStudent("Constance", "Jordan", "Iran", 12,
                new Classroom[] { grade12[11], grade12[10], grade12[7] }, new int[] { 64, 59, 95 });
            Student s181 = MakeStudent("Brad", "Henry", "Vietnam", 10,
                new Classroom[] { grade10[1], grade10[8], grade10[5] }, new int[] { 86, 55, 80 });
            Student s182 = MakeStudent("Amelia", "Coleman", "Spain", 11,
                new Classroom[] { grade11[11], grade11[1], grade11[0], grade11[12], grade11[6] }, new int[] { 90, 61, 90, 67, 53 });
            Student s183 = MakeStudent("Craig", "Hudson", "Greece", 11,
                new Classroom[] { grade11[6], grade11[12] }, new int[] { 44, 56 });
            Student s184 = MakeStudent("Jean", "Hudson", "Mexico", 12,
                new Classroom[] { grade12[6] }, new int[] { 88 });
            Student s185 = MakeStudent("Mike", "Harvey", "Australia", 12,
                new Classroom[] { grade12[10], grade12[0], grade12[8] }, new int[] { 100, 69, 55 });
            Student s186 = MakeStudent("Evelyn", "Turner", "Russia", 12,
                new Classroom[] { grade12[6], grade12[4] }, new int[] { 67, 88 });
            Student s187 = MakeStudent("Raul", "Hale", "Egypt", 10,
                new Classroom[] { grade10[4], grade10[6] }, new int[] { 55, 47 });
            Student s188 = MakeStudent("Evan", "Fisher", "Russia", 10,
                new Classroom[] { grade10[12], grade10[6], grade10[10], grade10[4] }, new int[] { 84, 94, 62, 86 });
            Student s189 = MakeStudent("Lois", "Marshall", "Egypt", 12,
                new Classroom[] { grade12[1] }, new int[] { 69 });
            Student s190 = MakeStudent("Sue", "Fields", "Greece", 11,
                new Classroom[] { grade11[3], grade11[7], grade11[9], grade11[11], grade11[10] }, new int[] { 49, 67, 93, 95, 82 });
            Student s191 = MakeStudent("Juan", "Pearson", "South Korea", 12,
                new Classroom[] { grade12[8], grade12[8], grade12[10] }, new int[] { 48, 81, 99 });
            Student s192 = MakeStudent("Derrick", "Harper", "Greece", 11,
                new Classroom[] { grade11[9], grade11[9] }, new int[] { 54, 78 });
            Student s193 = MakeStudent("Lois", "Barnes", "Canada", 11,
                new Classroom[] { grade11[8], grade11[6] }, new int[] { 64, 95 });
            Student s194 = MakeStudent("Abigail", "Coleman", "China", 10,
                new Classroom[] { grade10[2], grade10[9], grade10[1] }, new int[] { 64, 93, 48 });
            Student s195 = MakeStudent("Flenn", "Craig", "Turkey", 10,
                new Classroom[] { grade10[6], grade10[4], grade10[7], grade10[10] }, new int[] { 43, 50, 48, 59 });
            Student s196 = MakeStudent("Gordon", "Peck", "United States", 12,
                new Classroom[] { grade12[9], grade12[12], grade12[0] }, new int[] { 43, 45, 96 });
            Student s197 = MakeStudent("Stephanie", "Carroll", "Australia", 10,
                new Classroom[] { grade10[11], grade10[2] }, new int[] { 81, 55 });
            Student s198 = MakeStudent("Billy", "Taylor", "Mexico", 10,
                new Classroom[] { grade10[10], grade10[2], grade10[2] }, new int[] { 40, 62, 62 });
            Student s199 = MakeStudent("Connor", "Edwards", "United States", 12,
                new Classroom[] { grade12[3] }, new int[] { 61 });
            #endregion Students100-199

            #region Students200-299
            Student s200 = MakeStudent("Barry", "Jennings", "Spain", 11,
                new Classroom[] { grade11[4] }, new int[] { 66 });
            Student s201 = MakeStudent("Noelle", "Harrison", "China", 10,
                new Classroom[] { grade10[8], grade10[11], grade10[8] }, new int[] { 67, 87, 57 });
            Student s202 = MakeStudent("Robin", "Lewis", "South Korea", 11,
                new Classroom[] { grade11[8] }, new int[] { 56 });
            Student s203 = MakeStudent("Theresa", "Rodriguez", "Iran", 10,
                new Classroom[] { grade10[2], grade10[9] }, new int[] { 75, 56 });
            Student s204 = MakeStudent("David", "Simmons", "France", 11,
                new Classroom[] { grade11[11], grade11[6], grade11[0], grade11[11] }, new int[] { 84, 66, 91, 42 });
            Student s205 = MakeStudent("Brianna", "Barnett", "Nigeria", 12,
                new Classroom[] { grade12[5] }, new int[] { 43 });
            Student s206 = MakeStudent("Camila", "Peck", "Japan", 10,
                new Classroom[] { grade10[3], grade10[1], grade10[1], grade10[0], grade10[1] }, new int[] { 40, 85, 78, 56, 92 });
            Student s207 = MakeStudent("Mathew", "Parker", "Nigeria", 12,
                new Classroom[] { grade12[7], grade12[8], grade12[2], grade12[4] }, new int[] { 81, 87, 54, 40 });
            Student s208 = MakeStudent("Linda", "Palmer", "South Korea", 11,
                new Classroom[] { grade11[10] }, new int[] { 55 });
            Student s209 = MakeStudent("Connie", "Holmes", "South Korea", 10,
                new Classroom[] { grade10[3], grade10[3] }, new int[] { 72, 73 });
            Student s210 = MakeStudent("Layla", "Austin", "Vietnam", 12,
                new Classroom[] { grade12[6], grade12[1], grade12[5] }, new int[] { 53, 69, 80 });
            Student s211 = MakeStudent("Carl", "Vasquez", "South Korea", 11,
                new Classroom[] { grade11[10], grade11[12], grade11[0], grade11[10], grade11[11] }, new int[] { 47, 83, 82, 48, 54 });
            Student s212 = MakeStudent("Maurice", "Graham", "Vietnam", 11,
                new Classroom[] { grade11[10], grade11[0] }, new int[] { 76, 75 });
            Student s213 = MakeStudent("Phyllis", "Franklin", "Vietnam", 10,
                new Classroom[] { grade10[6], grade10[10] }, new int[] { 40, 100 });
            Student s214 = MakeStudent("Claire", "Rivera", "England", 11,
                new Classroom[] { grade11[3], grade11[10] }, new int[] { 87, 78 });
            Student s215 = MakeStudent("Christine", "Wallace", "South Korea", 12,
                new Classroom[] { grade12[9], grade12[9], grade12[10], grade12[11] }, new int[] { 76, 83, 83, 72 });
            Student s216 = MakeStudent("Eduardo", "Mitchelle", "Vietnam", 11,
                new Classroom[] { grade11[4], grade11[9], grade11[7], grade11[0], grade11[10] }, new int[] { 91, 45, 96, 56, 68 });
            Student s217 = MakeStudent("Ricardo", "Miles", "Egypt", 12,
                new Classroom[] { grade12[1], grade12[8], grade12[5], grade12[3], grade12[1] }, new int[] { 91, 78, 56, 76, 57 });
            Student s218 = MakeStudent("Chester", "Coleman", "Mexico", 11,
                new Classroom[] { grade11[8], grade11[5], grade11[4], grade11[7], grade11[8] }, new int[] { 67, 57, 51, 90, 50 });
            Student s219 = MakeStudent("Johnni", "Cooper", "Egypt", 11,
                new Classroom[] { grade11[9] }, new int[] { 92 });
            Student s220 = MakeStudent("Edward", "Riley", "China", 12,
                new Classroom[] { grade12[12], grade12[10] }, new int[] { 43, 88 });
            Student s221 = MakeStudent("Hailey", "Burke", "United States", 11,
                new Classroom[] { grade11[10], grade11[12], grade11[6] }, new int[] { 60, 72, 45 });
            Student s222 = MakeStudent("Eleanor", "Nelson", "Australia", 11,
                new Classroom[] { grade11[5], grade11[10] }, new int[] { 57, 44 });
            Student s223 = MakeStudent("Tyler", "Nelson", "Greece", 11,
                new Classroom[] { grade11[0] }, new int[] { 50 });
            Student s224 = MakeStudent("Philip", "Parker", "South Korea", 10,
                new Classroom[] { grade10[6] }, new int[] { 62 });
            Student s225 = MakeStudent("Amelia", "Miles", "United States", 11,
                new Classroom[] { grade11[9], grade11[6] }, new int[] { 86, 60 });
            Student s226 = MakeStudent("Patsy", "Hanson", "Canada", 12,
                new Classroom[] { grade12[6], grade12[0], grade12[8] }, new int[] { 73, 95, 79 });
            Student s227 = MakeStudent("Perry", "Gardner", "Spain", 11,
                new Classroom[] { grade11[12], grade11[4], grade11[6], grade11[6] }, new int[] { 80, 64, 54, 71 });
            Student s228 = MakeStudent("Erin", "Turner", "Turkey", 12,
                new Classroom[] { grade12[9], grade12[5], grade12[8], grade12[10] }, new int[] { 67, 53, 52, 46 });
            Student s229 = MakeStudent("Amy", "Riley", "South Korea", 12,
                new Classroom[] { grade12[12], grade12[1], grade12[8], grade12[6], grade12[4] }, new int[] { 53, 69, 46, 96, 89 });
            Student s230 = MakeStudent("Bruce", "Pearson", "Nigeria", 11,
                new Classroom[] { grade11[2], grade11[6], grade11[3] }, new int[] { 78, 87, 96 });
            Student s231 = MakeStudent("Evan", "Garza", "China", 10,
                new Classroom[] { grade10[4], grade10[1], grade10[6], grade10[3], grade10[9] }, new int[] { 53, 69, 63, 45, 87 });
            Student s232 = MakeStudent("Joel", "Garrett", "Australia", 11,
                new Classroom[] { grade11[10], grade11[0], grade11[7] }, new int[] { 42, 52, 92 });
            Student s233 = MakeStudent("Mario", "Schmidt", "Russia", 10,
                new Classroom[] { grade10[6], grade10[2], grade10[7], grade10[2], grade10[5] }, new int[] { 88, 84, 84, 95, 55 });
            Student s234 = MakeStudent("Crystal", "Ruiz", "United States", 11,
                new Classroom[] { grade11[8], grade11[12] }, new int[] { 41, 95 });
            Student s235 = MakeStudent("Larry", "Kelley", "Russia", 10,
                new Classroom[] { grade10[11], grade10[0], grade10[10] }, new int[] { 65, 92, 92 });
            Student s236 = MakeStudent("Gordon", "Ramirez", "Russia", 11,
                new Classroom[] { grade11[1], grade11[7], grade11[1], grade11[10] }, new int[] { 41, 50, 65, 40 });
            Student s237 = MakeStudent("Mattie", "Vargas", "Russia", 10,
                new Classroom[] { grade10[8], grade10[4] }, new int[] { 94, 49 });
            Student s238 = MakeStudent("Lesa", "Brewer", "Canada", 12,
                new Classroom[] { grade12[9], grade12[3], grade12[4], grade12[7], grade12[12] }, new int[] { 47, 89, 57, 40, 65 });
            Student s239 = MakeStudent("Rose", "Miles", "Egypt", 11,
                new Classroom[] { grade11[1], grade11[2], grade11[6], grade11[7] }, new int[] { 97, 92, 88, 61 });
            Student s240 = MakeStudent("Wanda", "Fernandez", "England", 11,
                new Classroom[] { grade11[8], grade11[7] }, new int[] { 64, 52 });
            Student s241 = MakeStudent("Avery", "Hayes", "Japan", 10,
                new Classroom[] { grade10[12], grade10[9] }, new int[] { 90, 71 });
            Student s242 = MakeStudent("Stephanie", "Stevens", "Egypt", 10,
                new Classroom[] { grade10[9], grade10[5], grade10[10], grade10[9] }, new int[] { 76, 86, 64, 52 });
            Student s243 = MakeStudent("Landon", "Burton", "Mexico", 11,
                new Classroom[] { grade11[11], grade11[10], grade11[2], grade11[3] }, new int[] { 93, 58, 100, 50 });
            Student s244 = MakeStudent("Joan", "Mckinney", "Spain", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[12] }, new int[] { 44, 100, 100 });
            Student s245 = MakeStudent("Beatrice", "Simmmons", "Mexico", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[10] }, new int[] { 95, 89, 81 });
            Student s246 = MakeStudent("Gabriella", "Garcia", "Egypt", 12,
                new Classroom[] { grade12[10] }, new int[] { 53 });
            Student s247 = MakeStudent("Edgar", "Douglas", "United States", 12,
                new Classroom[] { grade12[7], grade12[12], grade12[3], grade12[8] }, new int[] { 77, 90, 58, 42 });
            Student s248 = MakeStudent("Terrance", "Jenkins", "United States", 10,
                new Classroom[] { grade10[2], grade10[7], grade10[11], grade10[9], grade10[11] }, new int[] { 58, 71, 50, 91, 67 });
            Student s249 = MakeStudent("Mae", "Anderson", "China", 12,
                new Classroom[] { grade12[2], grade12[7], grade12[9], grade12[3], grade12[8] }, new int[] { 54, 89, 75, 74, 53 });
            Student s250 = MakeStudent("Brianna", "Beck", "Nigeria", 10,
                new Classroom[] { grade10[2], grade10[9], grade10[2], grade10[9] }, new int[] { 79, 65, 67, 40 });
            Student s251 = MakeStudent("Johnny", "Smith", "Canada", 12,
                new Classroom[] { grade12[12], grade12[5] }, new int[] { 83, 60 });
            Student s252 = MakeStudent("Lisa", "Franklin", "Spain", 12,
                new Classroom[] { grade12[8] }, new int[] { 68 });
            Student s253 = MakeStudent("Roberta", "Chavez", "Turkey", 11,
                new Classroom[] { grade11[4], grade11[1], grade11[8], grade11[0], grade11[7] }, new int[] { 88, 55, 58, 50, 91 });
            Student s254 = MakeStudent("Keith", "Herrera", "Mexico", 11,
                new Classroom[] { grade11[5], grade11[4] }, new int[] { 73, 63 });
            Student s255 = MakeStudent("Monica", "Berry", "China", 12,
                new Classroom[] { grade12[1], grade12[8], grade12[2] }, new int[] { 81, 92, 96 });
            Student s256 = MakeStudent("Jessica", "Lambert", "Greece", 12,
                new Classroom[] { grade12[6], grade12[1] }, new int[] { 50, 66 });
            Student s257 = MakeStudent("Rachel", "Caldwell", "China", 12,
                new Classroom[] { grade12[6], grade12[1] }, new int[] { 57, 76 });
            Student s258 = MakeStudent("Martin", "Kennedy", "England", 12,
                new Classroom[] { grade12[3], grade12[7], grade12[10], grade12[11], grade12[6] }, new int[] { 99, 66, 100, 72, 64 });
            Student s259 = MakeStudent("Susan", "Gordon", "Canada", 12,
                new Classroom[] { grade12[4], grade12[10], grade12[2], grade12[1], grade12[11] }, new int[] { 67, 79, 80, 58, 100 });
            Student s260 = MakeStudent("Melanie", "Matthews", "Vietnam", 10,
                new Classroom[] { grade10[10] }, new int[] { 48 });
            Student s261 = MakeStudent("Melanie", "Sullivan", "England", 10,
                new Classroom[] { grade10[9], grade10[12], grade10[10], grade10[5] }, new int[] { 68, 70, 57, 73 });
            Student s262 = MakeStudent("Earl", "Jennings", "Nigeria", 12,
                new Classroom[] { grade12[7] }, new int[] { 67 });
            Student s263 = MakeStudent("Christopher", "Brewer", "Egypt", 11,
                new Classroom[] { grade11[8], grade11[1] }, new int[] { 71, 92 });
            Student s264 = MakeStudent("Douglas", "Dixon", "South Korea", 12,
                new Classroom[] { grade12[1], grade12[5], grade12[8] }, new int[] { 98, 46, 94 });
            Student s265 = MakeStudent("Rafael", "Brooks", "South Korea", 11,
                new Classroom[] { grade11[11], grade11[11], grade11[12], grade11[7] }, new int[] { 52, 85, 96, 40 });
            Student s266 = MakeStudent("Brianna", "Garcia", "Iran", 12,
                new Classroom[] { grade12[2], grade12[1], grade12[10], grade12[10], grade12[2] }, new int[] { 83, 95, 95, 80, 87 });
            Student s267 = MakeStudent("Owen", "Hill", "Mexico", 11,
                new Classroom[] { grade11[4], grade11[1] }, new int[] { 58, 82 });
            Student s268 = MakeStudent("Teresa", "Johnson", "Mexico", 10,
                new Classroom[] { grade10[11], grade10[1], grade10[6], grade10[7] }, new int[] { 47, 74, 86, 74 });
            Student s269 = MakeStudent("Jennie", "Stewart", "Canada", 12,
                new Classroom[] { grade12[1], grade12[3] }, new int[] { 50, 79 });
            Student s270 = MakeStudent("Evan", "Williamson", "United States", 11,
                new Classroom[] { grade11[4], grade11[6] }, new int[] { 44, 88 });
            Student s271 = MakeStudent("Kathy", "Sutton", "China", 10,
                new Classroom[] { grade10[6], grade10[8], grade10[4] }, new int[] { 44, 79, 91 });
            Student s272 = MakeStudent("Isabella", "Harris", "Iran", 12,
                new Classroom[] { grade12[6] }, new int[] { 96 });
            Student s273 = MakeStudent("Curtis", "Schmidt", "United States", 12,
                new Classroom[] { grade12[3], grade12[7], grade12[4] }, new int[] { 63, 95, 75 });
            Student s274 = MakeStudent("Duane", "Bishop", "Egypt", 12,
                new Classroom[] { grade12[0], grade12[6] }, new int[] { 91, 73 });
            Student s275 = MakeStudent("Lee", "Rivera", "Mexico", 10,
                new Classroom[] { grade10[8], grade10[10], grade10[4] }, new int[] { 86, 93, 45 });
            Student s276 = MakeStudent("Joel", "Reynolds", "Turkey", 10,
                new Classroom[] { grade10[1] }, new int[] { 75 });
            Student s277 = MakeStudent("Erin", "Larson", "Vietnam", 12,
                new Classroom[] { grade12[4], grade12[9], grade12[5], grade12[9] }, new int[] { 44, 91, 71, 85 });
            Student s278 = MakeStudent("Bradley", "Murray", "United States", 11,
                new Classroom[] { grade11[3] }, new int[] { 52 });
            Student s279 = MakeStudent("Barry", "Romero", "Spain", 10,
                new Classroom[] { grade10[5] }, new int[] { 54 });
            Student s280 = MakeStudent("Shelly", "Snyder", "Spain", 10,
                new Classroom[] { grade10[2], grade10[7], grade10[5], grade10[1], grade10[1] }, new int[] { 40, 97, 47, 85, 92 });
            Student s281 = MakeStudent("Susan", "Prescott", "France", 11,
                new Classroom[] { grade11[11], grade11[5], grade11[12], grade11[8], grade11[3] }, new int[] { 85, 41, 100, 60, 66 });
            Student s282 = MakeStudent("Constance", "Montgomery", "England", 11,
                new Classroom[] { grade11[2], grade11[9], grade11[12], grade11[12], grade11[1] }, new int[] { 79, 63, 66, 78, 91 });
            Student s283 = MakeStudent("Gladys", "Rodriguez", "South Korea", 11,
                new Classroom[] { grade11[7], grade11[10] }, new int[] { 65, 70 });
            Student s284 = MakeStudent("Serenity", "Stephens", "Mexico", 11,
                new Classroom[] { grade11[10], grade11[10], grade11[6], grade11[2] }, new int[] { 76, 86, 62, 85 });
            Student s285 = MakeStudent("Jimmy", "Bell", "Egypt", 11,
                new Classroom[] { grade11[4] }, new int[] { 84 });
            Student s286 = MakeStudent("Marcus", "Gray", "England", 12,
                new Classroom[] { grade12[11], grade12[11], grade12[10], grade12[9], grade12[7] }, new int[] { 72, 48, 57, 63, 100 });
            Student s287 = MakeStudent("Samuel", "Bates", "Russia", 12,
                new Classroom[] { grade12[11] }, new int[] { 82 });
            Student s288 = MakeStudent("Mary", "Simmmons", "Nigeria", 10,
                new Classroom[] { grade10[12], grade10[8], grade10[1], grade10[10], grade10[12] }, new int[] { 65, 92, 92, 73, 95 });
            Student s289 = MakeStudent("Michael", "Morrison", "Nigeria", 11,
                new Classroom[] { grade11[2], grade11[2], grade11[1], grade11[9] }, new int[] { 57, 73, 77, 69 });
            Student s290 = MakeStudent("Guy", "Torres", "France", 12,
                new Classroom[] { grade12[5], grade12[11], grade12[12], grade12[11] }, new int[] { 86, 59, 48, 72 });
            Student s291 = MakeStudent("Claudia", "May", "Greece", 10,
                new Classroom[] { grade10[12], grade10[8], grade10[4], grade10[9] }, new int[] { 73, 43, 47, 52 });
            Student s292 = MakeStudent("Guy", "Murray", "Mexico", 10,
                new Classroom[] { grade10[8], grade10[0] }, new int[] { 57, 81 });
            Student s293 = MakeStudent("Ben", "Griffin", "Spain", 11,
                new Classroom[] { grade11[5], grade11[10], grade11[10] }, new int[] { 50, 64, 42 });
            Student s294 = MakeStudent("Chris", "George", "Canada", 10,
                new Classroom[] { grade10[1] }, new int[] { 89 });
            Student s295 = MakeStudent("Cherly", "Gibson", "Egypt", 10,
                new Classroom[] { grade10[4] }, new int[] { 94 });
            Student s296 = MakeStudent("Diane", "Ortiz", "Nigeria", 10,
                new Classroom[] { grade10[6] }, new int[] { 47 });
            Student s297 = MakeStudent("Allen", "Wells", "Russia", 10,
                new Classroom[] { grade10[12], grade10[1], grade10[8], grade10[2], grade10[5] }, new int[] { 58, 91, 41, 79, 79 });
            Student s298 = MakeStudent("Arianna", "Rhodes", "Greece", 11,
                new Classroom[] { grade11[6], grade11[3] }, new int[] { 67, 99 });
            Student s299 = MakeStudent("Doris", "Garcia", "Mexico", 10,
                new Classroom[] { grade10[10], grade10[4], grade10[12] }, new int[] { 43, 77, 84 });
            #endregion Students200-299

            #region Students300-399
            Student s300 = MakeStudent("Tracy", "Mccoy", "Turkey", 12,
                new Classroom[] { grade12[10], grade12[1] }, new int[] { 52, 61 });
            Student s301 = MakeStudent("Danny", "Baker", "Mexico", 11,
                new Classroom[] { grade11[2] }, new int[] { 81 });
            Student s302 = MakeStudent("Willard", "Carr", "Russia", 11,
                new Classroom[] { grade11[3], grade11[4], grade11[8] }, new int[] { 83, 70, 70 });
            Student s303 = MakeStudent("Anita", "Holt", "Russia", 12,
                new Classroom[] { grade12[10], grade12[2], grade12[2], grade12[9], grade12[4] }, new int[] { 67, 71, 99, 87, 91 });
            Student s304 = MakeStudent("June", "Roberts", "Spain", 11,
                new Classroom[] { grade11[4], grade11[6], grade11[5], grade11[6], grade11[4] }, new int[] { 62, 51, 79, 91, 92 });
            Student s305 = MakeStudent("Wesley", "May", "Mexico", 11,
                new Classroom[] { grade11[11], grade11[2], grade11[11] }, new int[] { 43, 53, 93 });
            Student s306 = MakeStudent("Janet", "Hamilton", "Russia", 10,
                new Classroom[] { grade10[1], grade10[1] }, new int[] { 84, 94 });
            Student s307 = MakeStudent("Amelia", "Bailey", "France", 11,
                new Classroom[] { grade11[11], grade11[0], grade11[2] }, new int[] { 65, 41, 95 });
            Student s308 = MakeStudent("Danny", "Hernandez", "Iran", 10,
                new Classroom[] { grade10[10], grade10[12], grade10[12], grade10[2] }, new int[] { 67, 54, 54, 98 });
            Student s309 = MakeStudent("Felix", "Rose", "Mexico", 12,
                new Classroom[] { grade12[11], grade12[1], grade12[8], grade12[6] }, new int[] { 78, 94, 73, 44 });
            Student s310 = MakeStudent("Alexander", "Rodriguez", "England", 11,
                new Classroom[] { grade11[3], grade11[2], grade11[0], grade11[4], grade11[9] }, new int[] { 80, 50, 66, 53, 99 });
            Student s311 = MakeStudent("Stephanie", "Harper", "Nigeria", 12,
                new Classroom[] { grade12[0], grade12[7], grade12[2], grade12[5], grade12[6] }, new int[] { 84, 61, 86, 96, 71 });
            Student s312 = MakeStudent("Alex", "Simmmons", "Australia", 12,
                new Classroom[] { grade12[1], grade12[12], grade12[12], grade12[7] }, new int[] { 77, 97, 53, 76 });
            Student s313 = MakeStudent("Chloe", "Johnston", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[11], grade10[3], grade10[5] }, new int[] { 93, 57, 67, 58 });
            Student s314 = MakeStudent("Alma", "Mills", "Turkey", 10,
                new Classroom[] { grade10[5], grade10[4], grade10[6] }, new int[] { 53, 74, 77 });
            Student s315 = MakeStudent("Kylie", "Diaz", "Greece", 11,
                new Classroom[] { grade11[8], grade11[9], grade11[8] }, new int[] { 80, 83, 48 });
            Student s316 = MakeStudent("Jacqueline", "Chapman", "Mexico", 12,
                new Classroom[] { grade12[11], grade12[9] }, new int[] { 89, 53 });
            Student s317 = MakeStudent("Danny", "Carr", "Turkey", 11,
                new Classroom[] { grade11[12], grade11[5], grade11[5], grade11[9], grade11[5] }, new int[] { 90, 91, 98, 52, 45 });
            Student s318 = MakeStudent("Willie", "Henderson", "Australia", 11,
                new Classroom[] { grade11[5] }, new int[] { 65 });
            Student s319 = MakeStudent("Antonio", "Lane", "South Korea", 11,
                new Classroom[] { grade11[6], grade11[0], grade11[11], grade11[11], grade11[6] }, new int[] { 69, 93, 59, 44, 84 });
            Student s320 = MakeStudent("Gwendolyn", "Fuller", "England", 11,
                new Classroom[] { grade11[7], grade11[8], grade11[5], grade11[11], grade11[4] }, new int[] { 96, 79, 71, 54, 56 });
            Student s321 = MakeStudent("Sara", "Fletcher", "Nigeria", 11,
                new Classroom[] { grade11[0] }, new int[] { 88 });
            Student s322 = MakeStudent("Maurice", "Gibson", "Japan", 11,
                new Classroom[] { grade11[4], grade11[2], grade11[9], grade11[7], grade11[3] }, new int[] { 77, 64, 47, 49, 46 });
            Student s323 = MakeStudent("Lesa", "Henry", "Iran", 11,
                new Classroom[] { grade11[7], grade11[10] }, new int[] { 93, 75 });
            Student s324 = MakeStudent("Timmothy", "Sutton", "Spain", 12,
                new Classroom[] { grade12[2], grade12[5], grade12[0], grade12[4] }, new int[] { 65, 74, 56, 84 });
            Student s325 = MakeStudent("Maxine", "Murphy", "South Korea", 11,
                new Classroom[] { grade11[6], grade11[0], grade11[11] }, new int[] { 87, 49, 81 });
            Student s326 = MakeStudent("Kitty", "Romero", "Spain", 12,
                new Classroom[] { grade12[8] }, new int[] { 72 });
            Student s327 = MakeStudent("Marion", "George", "Greece", 10,
                new Classroom[] { grade10[12], grade10[1] }, new int[] { 97, 71 });
            Student s328 = MakeStudent("Timmothy", "Banks", "United States", 12,
                new Classroom[] { grade12[5], grade12[8], grade12[6] }, new int[] { 80, 65, 77 });
            Student s329 = MakeStudent("Devon", "Payne", "Australia", 10,
                new Classroom[] { grade10[2], grade10[5], grade10[1], grade10[10] }, new int[] { 68, 42, 89, 97 });
            Student s330 = MakeStudent("Kelly", "Bennett", "South Korea", 10,
                new Classroom[] { grade10[2], grade10[10], grade10[12] }, new int[] { 93, 44, 57 });
            Student s331 = MakeStudent("Julian", "Martin", "China", 10,
                new Classroom[] { grade10[10], grade10[5], grade10[5], grade10[12] }, new int[] { 73, 52, 67, 83 });
            Student s332 = MakeStudent("Andre", "Watson", "England", 12,
                new Classroom[] { grade12[12], grade12[7], grade12[6] }, new int[] { 85, 44, 98 });
            Student s333 = MakeStudent("Jessie", "Schmidt", "Iran", 12,
                new Classroom[] { grade12[3] }, new int[] { 83 });
            Student s334 = MakeStudent("Elaine", "Reynolds", "United States", 12,
                new Classroom[] { grade12[11], grade12[3], grade12[0] }, new int[] { 99, 49, 76 });
            Student s335 = MakeStudent("April", "Castro", "United States", 12,
                new Classroom[] { grade12[1] }, new int[] { 45 });
            Student s336 = MakeStudent("Dawn", "Bates", "Iran", 10,
                new Classroom[] { grade10[3], grade10[8], grade10[4], grade10[9], grade10[4] }, new int[] { 68, 84, 77, 83, 60 });
            Student s337 = MakeStudent("Isaiah", "Horton", "Spain", 11,
                new Classroom[] { grade11[7], grade11[3] }, new int[] { 44, 99 });
            Student s338 = MakeStudent("Gertrude", "Lynch", "United States", 10,
                new Classroom[] { grade10[8], grade10[8], grade10[8] }, new int[] { 45, 83, 90 });
            Student s339 = MakeStudent("Mike", "Garrett", "Russia", 12,
                new Classroom[] { grade12[1] }, new int[] { 94 });
            Student s340 = MakeStudent("Jeanne", "Fisher", "China", 12,
                new Classroom[] { grade12[10], grade12[8], grade12[9], grade12[7], grade12[11] }, new int[] { 60, 67, 44, 46, 91 });
            Student s341 = MakeStudent("Mary", "Ramirez", "Vietnam", 11,
                new Classroom[] { grade11[12], grade11[0], grade11[4], grade11[4] }, new int[] { 63, 100, 64, 98 });
            Student s342 = MakeStudent("Noelle", "Hicks", "Iran", 10,
                new Classroom[] { grade10[4], grade10[2], grade10[3] }, new int[] { 95, 54, 96 });
            Student s343 = MakeStudent("Franklin", "Rivera", "Greece", 11,
                new Classroom[] { grade11[2], grade11[2], grade11[2], grade11[2] }, new int[] { 52, 70, 53, 89 });
            Student s344 = MakeStudent("Becky", "Gray", "Russia", 10,
                new Classroom[] { grade10[11], grade10[11], grade10[9], grade10[8], grade10[7] }, new int[] { 49, 48, 77, 48, 57 });
            Student s345 = MakeStudent("Travis", "Jacobs", "Australia", 10,
                new Classroom[] { grade10[3], grade10[1], grade10[11], grade10[10], grade10[6] }, new int[] { 61, 76, 51, 83, 74 });
            Student s346 = MakeStudent("Josephine", "Bradley", "Nigeria", 10,
                new Classroom[] { grade10[11], grade10[0] }, new int[] { 92, 68 });
            Student s347 = MakeStudent("Arianna", "Welch", "Japan", 11,
                new Classroom[] { grade11[12] }, new int[] { 55 });
            Student s348 = MakeStudent("Danielle", "Montgomery", "Vietnam", 12,
                new Classroom[] { grade12[2], grade12[0] }, new int[] { 96, 46 });
            Student s349 = MakeStudent("Kurt", "Welch", "Turkey", 10,
                new Classroom[] { grade10[9], grade10[4], grade10[5], grade10[1], grade10[12] }, new int[] { 84, 68, 49, 72, 75 });
            Student s350 = MakeStudent("Daniel", "Banks", "Canada", 12,
                new Classroom[] { grade12[11], grade12[8], grade12[11] }, new int[] { 70, 49, 65 });
            Student s351 = MakeStudent("Brooklyn", "Sullivan", "United States", 10,
                new Classroom[] { grade10[12], grade10[1], grade10[12], grade10[4] }, new int[] { 68, 65, 95, 78 });
            Student s352 = MakeStudent("Marion", "Holmes", "Egypt", 10,
                new Classroom[] { grade10[3], grade10[4], grade10[0], grade10[9], grade10[10] }, new int[] { 95, 93, 96, 57, 73 });
            Student s353 = MakeStudent("Stacey", "Stevens", "France", 10,
                new Classroom[] { grade10[9], grade10[3], grade10[7], grade10[11], grade10[10] }, new int[] { 90, 69, 63, 48, 72 });
            Student s354 = MakeStudent("Jenny", "Andrews", "Canada", 10,
                new Classroom[] { grade10[10], grade10[1], grade10[8] }, new int[] { 65, 98, 40 });
            Student s355 = MakeStudent("Bella", "Romero", "Russia", 11,
                new Classroom[] { grade11[6], grade11[9], grade11[3], grade11[7], grade11[6] }, new int[] { 55, 68, 77, 96, 89 });
            Student s356 = MakeStudent("Gerald", "Gonzalez", "Nigeria", 10,
                new Classroom[] { grade10[1], grade10[11], grade10[0], grade10[1], grade10[7] }, new int[] { 55, 98, 75, 57, 51 });
            Student s357 = MakeStudent("Dwight", "Davidson", "England", 12,
                new Classroom[] { grade12[8], grade12[7], grade12[6], grade12[10] }, new int[] { 74, 73, 44, 55 });
            Student s358 = MakeStudent("Russell", "Perry", "Nigeria", 10,
                new Classroom[] { grade10[11] }, new int[] { 85 });
            Student s359 = MakeStudent("Sara", "Thomas", "United States", 10,
                new Classroom[] { grade10[1], grade10[12], grade10[3] }, new int[] { 97, 57, 41 });
            Student s360 = MakeStudent("Brent", "Thompson", "Spain", 11,
                new Classroom[] { grade11[6], grade11[11], grade11[9] }, new int[] { 73, 47, 61 });
            Student s361 = MakeStudent("Esther", "Williamson", "Turkey", 11,
                new Classroom[] { grade11[3], grade11[8], grade11[7] }, new int[] { 86, 71, 55 });
            Student s362 = MakeStudent("Bruce", "Miles", "Japan", 11,
                new Classroom[] { grade11[0], grade11[4] }, new int[] { 61, 88 });
            Student s363 = MakeStudent("Peyton", "Johnston", "Spain", 10,
                new Classroom[] { grade10[5], grade10[10], grade10[3], grade10[12] }, new int[] { 72, 93, 79, 85 });
            Student s364 = MakeStudent("Adam", "Steeves ", "Mexico", 11,
                new Classroom[] { grade11[11] }, new int[] { 65 });
            Student s365 = MakeStudent("Connor", "Neal", "Spain", 12,
                new Classroom[] { grade12[2], grade12[3], grade12[4], grade12[7] }, new int[] { 77, 86, 86, 58 });
            Student s366 = MakeStudent("Beverly", "Stanley", "Canada", 12,
                new Classroom[] { grade12[6], grade12[8], grade12[12], grade12[11] }, new int[] { 57, 95, 89, 47 });
            Student s367 = MakeStudent("Victor", "Jacobs", "Turkey", 12,
                new Classroom[] { grade12[9], grade12[0], grade12[3], grade12[0], grade12[3] }, new int[] { 48, 77, 94, 44, 54 });
            Student s368 = MakeStudent("Gladys", "Armstrong", "Mexico", 12,
                new Classroom[] { grade12[1], grade12[10], grade12[4], grade12[3] }, new int[] { 76, 89, 63, 70 });
            Student s369 = MakeStudent("Ricardo", "Little", "Mexico", 11,
                new Classroom[] { grade11[6], grade11[3] }, new int[] { 69, 66 });
            Student s370 = MakeStudent("Annie", "Flores", "Australia", 10,
                new Classroom[] { grade10[9], grade10[9], grade10[2], grade10[3] }, new int[] { 58, 81, 43, 57 });
            Student s371 = MakeStudent("Bella", "Montgomery", "Iran", 10,
                new Classroom[] { grade10[0], grade10[6] }, new int[] { 41, 61 });
            Student s372 = MakeStudent("Miriam", "Johnston", "England", 11,
                new Classroom[] { grade11[1] }, new int[] { 79 });
            Student s373 = MakeStudent("Jessie", "Wade", "Vietnam", 10,
                new Classroom[] { grade10[8], grade10[11], grade10[8], grade10[0], grade10[1] }, new int[] { 53, 44, 98, 61, 63 });
            Student s374 = MakeStudent("Willie", "Crawford", "Russia", 12,
                new Classroom[] { grade12[5], grade12[6] }, new int[] { 48, 81 });
            Student s375 = MakeStudent("Roberto", "Andrews", "France", 11,
                new Classroom[] { grade11[11], grade11[8] }, new int[] { 99, 100 });
            Student s376 = MakeStudent("Andrew", "Young", "Australia", 12,
                new Classroom[] { grade12[10], grade12[8], grade12[6] }, new int[] { 58, 53, 76 });
            Student s377 = MakeStudent("Gwendolyn", "Washington", "United States", 11,
                new Classroom[] { grade11[1], grade11[4], grade11[2] }, new int[] { 59, 88, 50 });
            Student s378 = MakeStudent("Wallace", "Washington", "Spain", 10,
                new Classroom[] { grade10[12], grade10[6] }, new int[] { 63, 75 });
            Student s379 = MakeStudent("Carl", "Bell", "Egypt", 12,
                new Classroom[] { grade12[9], grade12[4], grade12[11], grade12[8], grade12[7] }, new int[] { 72, 78, 80, 63, 73 });
            Student s380 = MakeStudent("Sebastian", "Coleman", "Russia", 12,
                new Classroom[] { grade12[4], grade12[3], grade12[11], grade12[7] }, new int[] { 91, 40, 74, 72 });
            Student s381 = MakeStudent("Katherine", "Dean", "Nigeria", 12,
                new Classroom[] { grade12[8], grade12[2], grade12[0] }, new int[] { 59, 73, 92 });
            Student s382 = MakeStudent("Gabriel", "Steward", "Egypt", 10,
                new Classroom[] { grade10[1], grade10[4], grade10[0] }, new int[] { 84, 57, 59 });
            Student s383 = MakeStudent("Elizabeth", "Stephens", "Turkey", 12,
                new Classroom[] { grade12[12], grade12[2], grade12[5] }, new int[] { 57, 66, 57 });
            Student s384 = MakeStudent("Arianna", "Hamilton", "Mexico", 12,
                new Classroom[] { grade12[4], grade12[0], grade12[3], grade12[2] }, new int[] { 95, 40, 76, 42 });
            Student s385 = MakeStudent("Wyatt", "Banks", "Egypt", 11,
                new Classroom[] { grade11[4], grade11[6], grade11[7], grade11[0] }, new int[] { 83, 48, 94, 58 });
            Student s386 = MakeStudent("Brennan", "Weaver", "Canada", 10,
                new Classroom[] { grade10[10], grade10[9], grade10[3] }, new int[] { 96, 83, 93 });
            Student s387 = MakeStudent("Ruben", "Gonzalez", "Egypt", 10,
                new Classroom[] { grade10[10], grade10[1], grade10[4] }, new int[] { 99, 61, 98 });
            Student s388 = MakeStudent("Dustin", "Barrett", "Russia", 10,
                new Classroom[] { grade10[11], grade10[1], grade10[1], grade10[4] }, new int[] { 100, 74, 54, 55 });
            Student s389 = MakeStudent("Theresa", "Hughes", "United States", 12,
                new Classroom[] { grade12[10] }, new int[] { 81 });
            Student s390 = MakeStudent("Seth", "Phillips", "United States", 12,
                new Classroom[] { grade12[2], grade12[3] }, new int[] { 52, 60 });
            Student s391 = MakeStudent("Mattie", "Carlson", "Australia", 10,
                new Classroom[] { grade10[2], grade10[2], grade10[6] }, new int[] { 88, 96, 70 });
            Student s392 = MakeStudent("Hunter", "Gutierrez", "Egypt", 11,
                new Classroom[] { grade11[11] }, new int[] { 83 });
            Student s393 = MakeStudent("Scarlett", "Ryan", "United States", 10,
                new Classroom[] { grade10[8], grade10[5], grade10[3], grade10[5], grade10[10] }, new int[] { 56, 42, 59, 84, 43 });
            Student s394 = MakeStudent("Nicole", "Turner", "Vietnam", 11,
                new Classroom[] { grade11[10], grade11[4], grade11[10] }, new int[] { 65, 74, 71 });
            Student s395 = MakeStudent("Marlene", "Bennett", "Vietnam", 11,
                new Classroom[] { grade11[5], grade11[3], grade11[6], grade11[10] }, new int[] { 99, 48, 85, 45 });
            Student s396 = MakeStudent("Ronald", "Boyd", "France", 12,
                new Classroom[] { grade12[11], grade12[3], grade12[7], grade12[9], grade12[5] }, new int[] { 96, 67, 44, 73, 63 });
            Student s397 = MakeStudent("Duane", "Robertson", "China", 11,
                new Classroom[] { grade11[2], grade11[1] }, new int[] { 100, 94 });
            Student s398 = MakeStudent("Sarah", "Ross", "China", 10,
                new Classroom[] { grade10[7], grade10[5], grade10[3], grade10[10], grade10[11] }, new int[] { 73, 65, 94, 43, 97 });
            Student s399 = MakeStudent("Andy", "Gomez", "Iran", 10,
                new Classroom[] { grade10[1], grade10[9], grade10[4], grade10[7] }, new int[] { 56, 61, 86, 71 });
            #endregion Students300-399

            #region Students400-499
            Student s400 = MakeStudent("Hilda", "Snyder", "Egypt", 11,
                new Classroom[] { grade11[9], grade11[9] }, new int[] { 53, 89 });
            Student s401 = MakeStudent("Landon", "Pena", "Japan", 11,
                new Classroom[] { grade11[11] }, new int[] { 58 });
            Student s402 = MakeStudent("Tommy", "Jennings", "United States", 10,
                new Classroom[] { grade10[1], grade10[3] }, new int[] { 100, 92 });
            Student s403 = MakeStudent("Kristin", "Thomas", "Vietnam", 11,
                new Classroom[] { grade11[6], grade11[6] }, new int[] { 61, 85 });
            Student s404 = MakeStudent("Russell", "Snyder", "Japan", 12,
                new Classroom[] { grade12[11], grade12[0] }, new int[] { 54, 51 });
            Student s405 = MakeStudent("Ryan", "Rhodes", "Vietnam", 12,
                new Classroom[] { grade12[2], grade12[9], grade12[11] }, new int[] { 66, 41, 51 });
            Student s406 = MakeStudent("Eddie", "Bowman", "South Korea", 11,
                new Classroom[] { grade11[1], grade11[0], grade11[3], grade11[11] }, new int[] { 51, 93, 46, 53 });
            Student s407 = MakeStudent("Willie", "Bennett", "South Korea", 12,
                new Classroom[] { grade12[12], grade12[1], grade12[8] }, new int[] { 46, 77, 42 });
            Student s408 = MakeStudent("Edwin", "Coleman", "Spain", 11,
                new Classroom[] { grade11[10], grade11[12], grade11[5], grade11[10] }, new int[] { 58, 93, 68, 60 });
            Student s409 = MakeStudent("Marian", "Lane", "China", 11,
                new Classroom[] { grade11[2], grade11[4] }, new int[] { 71, 70 });
            Student s410 = MakeStudent("Clifford", "Steeves ", "Iran", 12,
                new Classroom[] { grade12[8] }, new int[] { 93 });
            Student s411 = MakeStudent("Cherly", "Curtis", "Vietnam", 12,
                new Classroom[] { grade12[10], grade12[8] }, new int[] { 69, 45 });
            Student s412 = MakeStudent("Gabriel", "Harvey", "England", 10,
                new Classroom[] { grade10[9], grade10[10], grade10[0], grade10[8], grade10[10] }, new int[] { 59, 69, 71, 49, 64 });
            Student s413 = MakeStudent("Frederick", "Long", "Mexico", 11,
                new Classroom[] { grade11[7], grade11[3] }, new int[] { 41, 83 });
            Student s414 = MakeStudent("Robert", "Stone", "France", 11,
                new Classroom[] { grade11[10], grade11[8], grade11[2], grade11[8] }, new int[] { 57, 51, 59, 70 });
            Student s415 = MakeStudent("Avery", "Fox", "Canada", 11,
                new Classroom[] { grade11[1], grade11[8], grade11[2] }, new int[] { 75, 54, 44 });
            Student s416 = MakeStudent("Frederick", "Ray", "Iran", 10,
                new Classroom[] { grade10[7], grade10[9] }, new int[] { 64, 75 });
            Student s417 = MakeStudent("Michele", "Edwards", "China", 10,
                new Classroom[] { grade10[2], grade10[7], grade10[11], grade10[0] }, new int[] { 58, 82, 95, 62 });
            Student s418 = MakeStudent("Nathan", "Adams", "Mexico", 12,
                new Classroom[] { grade12[3], grade12[8] }, new int[] { 56, 71 });
            Student s419 = MakeStudent("Zoe", "Marshall", "Egypt", 11,
                new Classroom[] { grade11[6] }, new int[] { 95 });
            Student s420 = MakeStudent("Eileen", "Price", "Greece", 12,
                new Classroom[] { grade12[10], grade12[6], grade12[2], grade12[2] }, new int[] { 46, 75, 43, 100 });
            Student s421 = MakeStudent("Tara", "Richards", "Spain", 10,
                new Classroom[] { grade10[1], grade10[9], grade10[1] }, new int[] { 51, 80, 63 });
            Student s422 = MakeStudent("Patsy", "Montgomery", "South Korea", 12,
                new Classroom[] { grade12[7], grade12[1], grade12[12], grade12[8], grade12[0] }, new int[] { 53, 50, 57, 57, 77 });
            Student s423 = MakeStudent("Troy", "Elliott", "Spain", 12,
                new Classroom[] { grade12[11], grade12[11], grade12[3] }, new int[] { 42, 95, 78 });
            Student s424 = MakeStudent("Ian", "Bradley", "United States", 12,
                new Classroom[] { grade12[4], grade12[8], grade12[7], grade12[7] }, new int[] { 51, 43, 79, 70 });
            Student s425 = MakeStudent("Nicholas", "Kennedy", "Canada", 10,
                new Classroom[] { grade10[10], grade10[6] }, new int[] { 73, 89 });
            Student s426 = MakeStudent("Christopher", "Austin", "Canada", 12,
                new Classroom[] { grade12[8] }, new int[] { 76 });
            Student s427 = MakeStudent("Tristan", "Murray", "Iran", 11,
                new Classroom[] { grade11[10] }, new int[] { 92 });
            Student s428 = MakeStudent("Esther", "Day", "Nigeria", 12,
                new Classroom[] { grade12[11], grade12[8], grade12[11] }, new int[] { 53, 60, 86 });
            Student s429 = MakeStudent("Troy", "Brewer", "Nigeria", 12,
                new Classroom[] { grade12[9] }, new int[] { 89 });
            Student s430 = MakeStudent("Noah", "Hayes", "Australia", 10,
                new Classroom[] { grade10[1], grade10[2], grade10[5], grade10[7] }, new int[] { 67, 89, 47, 69 });
            Student s431 = MakeStudent("Andre", "Diaz", "South Korea", 12,
                new Classroom[] { grade12[8] }, new int[] { 88 });
            Student s432 = MakeStudent("Mildred", "Bailey", "Greece", 12,
                new Classroom[] { grade12[1], grade12[4] }, new int[] { 42, 77 });
            Student s433 = MakeStudent("Taylor", "Evans", "Egypt", 11,
                new Classroom[] { grade11[4], grade11[7] }, new int[] { 60, 71 });
            Student s434 = MakeStudent("Theresa", "Rose", "Greece", 11,
                new Classroom[] { grade11[9], grade11[11], grade11[1], grade11[9] }, new int[] { 99, 90, 79, 97 });
            Student s435 = MakeStudent("Charlie", "Wagner", "United States", 12,
                new Classroom[] { grade12[11] }, new int[] { 50 });
            Student s436 = MakeStudent("Morris", "Boyd", "Russia", 10,
                new Classroom[] { grade10[6], grade10[6], grade10[8], grade10[8], grade10[11] }, new int[] { 48, 58, 57, 83, 85 });
            Student s437 = MakeStudent("Clarence", "Hanson", "Canada", 10,
                new Classroom[] { grade10[1], grade10[4], grade10[1], grade10[7], grade10[3] }, new int[] { 51, 87, 76, 67, 51 });
            Student s438 = MakeStudent("Lori", "Williamson", "Canada", 12,
                new Classroom[] { grade12[8], grade12[3], grade12[0], grade12[4] }, new int[] { 80, 62, 45, 53 });
            Student s439 = MakeStudent("Connor", "Johnston", "Canada", 12,
                new Classroom[] { grade12[4] }, new int[] { 60 });
            Student s440 = MakeStudent("Isaiah", "Hansen", "Nigeria", 11,
                new Classroom[] { grade11[3], grade11[2] }, new int[] { 65, 43 });
            Student s441 = MakeStudent("Carlos", "Peters", "England", 12,
                new Classroom[] { grade12[4], grade12[3] }, new int[] { 68, 91 });
            Student s442 = MakeStudent("Elizabeth", "Bryant", "Vietnam", 12,
                new Classroom[] { grade12[1] }, new int[] { 75 });
            Student s443 = MakeStudent("Riley", "Marshall", "France", 10,
                new Classroom[] { grade10[0], grade10[5], grade10[5], grade10[3], grade10[1] }, new int[] { 76, 58, 85, 41, 90 });
            Student s444 = MakeStudent("Paul", "Castro", "Nigeria", 12,
                new Classroom[] { grade12[12], grade12[12], grade12[9], grade12[9] }, new int[] { 40, 94, 50, 97 });
            Student s445 = MakeStudent("Beth", "Carr", "Russia", 11,
                new Classroom[] { grade11[10], grade11[9] }, new int[] { 54, 80 });
            Student s446 = MakeStudent("Oscar", "Ryan", "Egypt", 12,
                new Classroom[] { grade12[9], grade12[2], grade12[5], grade12[4], grade12[3] }, new int[] { 91, 51, 77, 43, 58 });
            Student s447 = MakeStudent("Bernice", "Coleman", "France", 10,
                new Classroom[] { grade10[3] }, new int[] { 66 });
            Student s448 = MakeStudent("Terra", "Young", "Mexico", 10,
                new Classroom[] { grade10[10], grade10[5], grade10[0], grade10[6] }, new int[] { 63, 72, 64, 87 });
            Student s449 = MakeStudent("Savannah", "Romero", "Greece", 11,
                new Classroom[] { grade11[10], grade11[1], grade11[10] }, new int[] { 45, 64, 40 });
            Student s450 = MakeStudent("Carrie", "Henderson", "Greece", 12,
                new Classroom[] { grade12[6], grade12[4], grade12[7] }, new int[] { 94, 86, 44 });
            Student s451 = MakeStudent("Dale", "Harper", "Mexico", 11,
                new Classroom[] { grade11[10], grade11[11], grade11[7], grade11[5], grade11[12] }, new int[] { 52, 91, 98, 97, 97 });
            Student s452 = MakeStudent("Tracy", "Bishop", "Nigeria", 11,
                new Classroom[] { grade11[0], grade11[3], grade11[2], grade11[10] }, new int[] { 89, 81, 95, 85 });
            Student s453 = MakeStudent("Brandie", "Meyer", "Vietnam", 12,
                new Classroom[] { grade12[7], grade12[0], grade12[1], grade12[3], grade12[3] }, new int[] { 68, 67, 40, 52, 98 });
            Student s454 = MakeStudent("Hilda", "Price", "Turkey", 10,
                new Classroom[] { grade10[0], grade10[3], grade10[4] }, new int[] { 51, 72, 75 });
            Student s455 = MakeStudent("Marian", "Rose", "China", 10,
                new Classroom[] { grade10[6], grade10[9], grade10[7], grade10[10] }, new int[] { 89, 74, 69, 66 });
            Student s456 = MakeStudent("Terra", "Montgomery", "South Korea", 11,
                new Classroom[] { grade11[6], grade11[12], grade11[5] }, new int[] { 77, 57, 69 });
            Student s457 = MakeStudent("Richard", "Ellis", "Nigeria", 12,
                new Classroom[] { grade12[7], grade12[8] }, new int[] { 61, 72 });
            Student s458 = MakeStudent("Sally", "Lowe", "England", 10,
                new Classroom[] { grade10[4], grade10[1], grade10[5], grade10[1], grade10[9] }, new int[] { 85, 70, 45, 47, 65 });
            Student s459 = MakeStudent("Julie", "Scott", "Nigeria", 10,
                new Classroom[] { grade10[6], grade10[3], grade10[5], grade10[0] }, new int[] { 47, 66, 63, 62 });
            Student s460 = MakeStudent("Terry", "Fox", "United States", 11,
                new Classroom[] { grade11[5], grade11[7] }, new int[] { 82, 67 });
            Student s461 = MakeStudent("Javier", "Ford", "Canada", 12,
                new Classroom[] { grade12[10], grade12[3] }, new int[] { 79, 82 });
            Student s462 = MakeStudent("Wilma", "Turner", "Canada", 12,
                new Classroom[] { grade12[2], grade12[12], grade12[5], grade12[8] }, new int[] { 90, 46, 88, 62 });
            Student s463 = MakeStudent("Owen", "Holmes", "England", 12,
                new Classroom[] { grade12[1], grade12[7], grade12[10] }, new int[] { 43, 87, 45 });
            Student s464 = MakeStudent("Ralph", "Richardson", "Vietnam", 11,
                new Classroom[] { grade11[5], grade11[5], grade11[1] }, new int[] { 43, 79, 95 });
            Student s465 = MakeStudent("Lonnie", "Miller", "England", 12,
                new Classroom[] { grade12[2], grade12[1], grade12[0] }, new int[] { 81, 83, 80 });
            Student s466 = MakeStudent("Eddie", "Diaz", "Canada", 12,
                new Classroom[] { grade12[12], grade12[11] }, new int[] { 41, 41 });
            Student s467 = MakeStudent("Dustin", "Johnson", "China", 10,
                new Classroom[] { grade10[7] }, new int[] { 89 });
            Student s468 = MakeStudent("Willie", "Mendoza", "Nigeria", 10,
                new Classroom[] { grade10[12] }, new int[] { 63 });
            Student s469 = MakeStudent("Barry", "Kennedy", "South Korea", 10,
                new Classroom[] { grade10[5], grade10[1] }, new int[] { 100, 88 });
            Student s470 = MakeStudent("Isaiah", "Bradley", "Canada", 11,
                new Classroom[] { grade11[2], grade11[7], grade11[9], grade11[2] }, new int[] { 90, 94, 79, 47 });
            Student s471 = MakeStudent("Melanie", "Burton", "Australia", 12,
                new Classroom[] { grade12[4], grade12[5] }, new int[] { 81, 80 });
            Student s472 = MakeStudent("Daisy", "Armstrong", "Egypt", 12,
                new Classroom[] { grade12[5] }, new int[] { 70 });
            Student s473 = MakeStudent("Wayne", "Berry", "Iran", 12,
                new Classroom[] { grade12[8], grade12[3], grade12[6], grade12[6], grade12[7] }, new int[] { 93, 69, 79, 45, 50 });
            Student s474 = MakeStudent("Gary", "Bennett", "Russia", 11,
                new Classroom[] { grade11[0], grade11[4], grade11[10], grade11[7] }, new int[] { 70, 90, 70, 75 });
            Student s475 = MakeStudent("Andy", "Patterson", "Spain", 11,
                new Classroom[] { grade11[4] }, new int[] { 91 });
            Student s476 = MakeStudent("Kevin", "Pena", "Canada", 11,
                new Classroom[] { grade11[12], grade11[0] }, new int[] { 43, 50 });
            Student s477 = MakeStudent("Hailey", "Morgan", "Greece", 12,
                new Classroom[] { grade12[3] }, new int[] { 75 });
            Student s478 = MakeStudent("Edna", "Banks", "Japan", 10,
                new Classroom[] { grade10[6], grade10[12], grade10[10], grade10[8] }, new int[] { 73, 56, 60, 71 });
            Student s479 = MakeStudent("Bill", "Hayes", "United States", 11,
                new Classroom[] { grade11[2], grade11[10] }, new int[] { 59, 71 });
            Student s480 = MakeStudent("Elizabeth", "Garza", "Nigeria", 10,
                new Classroom[] { grade10[5], grade10[4] }, new int[] { 58, 100 });
            Student s481 = MakeStudent("James", "Boyd", "Vietnam", 10,
                new Classroom[] { grade10[12], grade10[0] }, new int[] { 42, 70 });
            Student s482 = MakeStudent("Roger", "Campbell", "China", 10,
                new Classroom[] { grade10[0], grade10[1], grade10[4] }, new int[] { 49, 73, 53 });
            Student s483 = MakeStudent("Avery", "Carter", "Turkey", 11,
                new Classroom[] { grade11[8], grade11[1], grade11[9], grade11[4] }, new int[] { 52, 90, 93, 54 });
            Student s484 = MakeStudent("Robert", "Steward", "France", 11,
                new Classroom[] { grade11[11], grade11[0], grade11[12] }, new int[] { 51, 90, 77 });
            Student s485 = MakeStudent("Cindy", "Newman", "Vietnam", 12,
                new Classroom[] { grade12[1], grade12[5] }, new int[] { 99, 97 });
            Student s486 = MakeStudent("Seth", "Bates", "Egypt", 11,
                new Classroom[] { grade11[11] }, new int[] { 72 });
            Student s487 = MakeStudent("Nellie", "Hernandez", "Greece", 11,
                new Classroom[] { grade11[11], grade11[9], grade11[10] }, new int[] { 41, 70, 50 });
            Student s488 = MakeStudent("Carla", "Duncan", "Mexico", 12,
                new Classroom[] { grade12[9], grade12[9], grade12[5], grade12[6], grade12[8] }, new int[] { 50, 43, 94, 89, 47 });
            Student s489 = MakeStudent("Cindy", "Gilbert", "United States", 11,
                new Classroom[] { grade11[9], grade11[11], grade11[8] }, new int[] { 64, 57, 73 });
            Student s490 = MakeStudent("Ava", "Morrison", "Russia", 11,
                new Classroom[] { grade11[7] }, new int[] { 96 });
            Student s491 = MakeStudent("Lillie", "Jensen", "Mexico", 11,
                new Classroom[] { grade11[5], grade11[5], grade11[6], grade11[12] }, new int[] { 41, 59, 61, 90 });
            Student s492 = MakeStudent("Sylvia", "Reyes", "England", 12,
                new Classroom[] { grade12[10], grade12[4], grade12[6], grade12[12] }, new int[] { 84, 81, 98, 45 });
            Student s493 = MakeStudent("Brandy", "Carr", "Greece", 10,
                new Classroom[] { grade10[1] }, new int[] { 77 });
            Student s494 = MakeStudent("Stephanie", "Martin", "Spain", 11,
                new Classroom[] { grade11[11], grade11[0], grade11[11] }, new int[] { 46, 49, 58 });
            Student s495 = MakeStudent("Gordon", "Bishop", "Nigeria", 11,
                new Classroom[] { grade11[1] }, new int[] { 78 });
            Student s496 = MakeStudent("Martin", "Frazier", "Australia", 12,
                new Classroom[] { grade12[9], grade12[9], grade12[5], grade12[9], grade12[5] }, new int[] { 52, 57, 82, 50, 58 });
            Student s497 = MakeStudent("Jack", "Fleming", "Australia", 10,
                new Classroom[] { grade10[7], grade10[1], grade10[12], grade10[7] }, new int[] { 48, 42, 74, 97 });
            Student s498 = MakeStudent("Darrell", "Bishop", "Spain", 10,
                new Classroom[] { grade10[5] }, new int[] { 66 });
            Student s499 = MakeStudent("Renee", "Harrison", "Turkey", 12,
                new Classroom[] { grade12[0], grade12[3] }, new int[] { 40, 88 });
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
            }

            return newStudent;
        }
    }
}
