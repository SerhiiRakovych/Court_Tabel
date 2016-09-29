namespace WF_Test
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;


    #region Ініціалізація бази даних
    class AppUserContextInitializer : DropCreateDatabaseAlways<TableModel>
    //class AppUserContextInitializer : DropCreateDatabaseIfModelChanges<TableModel>
    {
        protected override void Seed(TableModel db)
        {
            //Зміна COLLATE поля "Логін" для врахування регістру символів
            db.Database.ExecuteSqlCommand("ALTER TABLE AppUsers ALTER COLUMN Login NVARCHAR(64) COLLATE Latin1_General_CS_AS NOT NULL");

            AppUser _user1 = new AppUser
            {
                Login = "admin",
                Password = "6CBBB93A0AD570EEE7E40BE52AB393E8",
                Salt = "2ABHYDFGXR",
                Name = "Технічний адміністратор системи",
                IsActive = true
            };

            AppUser _user2 = new AppUser
            {
                Login = "angelA",
                Password = "1D2CA7ED34B7351F4F99B0ACF847622F",
                Salt = "ULB82IJAVQ",
                Name = "Власенко Анжела Вікторівна",
                IsActive = true
            };

            db.AppUsers.Add(_user1);
            db.AppUsers.Add(_user2);

            Worker _worker1 = new Worker
            {
                FirstName = "Хоменко",
                LastName = "Жанна",
                MiddleName = "Василівна",
                Post = "Суддя",
                OrderNum = 4,
                IsArchive = false
            };

            Worker _worker2 = new Worker
            {
                FirstName = "Живодрот",
                LastName = "Спиридон",
                MiddleName = "Мафусаїлович",
                Post = "Помічник голови суду",
                OrderNum = 1,
                IsArchive = false
            };

            Worker _worker3 = new Worker
            {
                FirstName = "Савенко",
                LastName = "Анжела",
                MiddleName = "Миколаївна",
                Post = "Секретар судового засідання",
                OrderNum = 3,
                IsArchive = false
            };

            Worker _worker4 = new Worker
            {
                FirstName = "Зінченко",
                LastName = "Василь",
                MiddleName = "Мазафакович",
                Post = "Суддя",
                OrderNum = 6,
                IsArchive = true
            };

            db.Workers.Add(_worker1);
            db.Workers.Add(_worker2);
            db.Workers.Add(_worker3);
            db.Workers.Add(_worker4);
            db.SaveChanges();
        }
    }
    #endregion

    #region Клас AppUser
    public class AppUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
    #endregion 
    
    #region Клас Worker
    public class Worker
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не вказано прізвище працівника")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Поле \"Прізвище\": Довжина повинна бути від 2 до 50 символів")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не вказано ім'я працівника")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Поле \"Ім'я\": Довжина повинна бути від 2 до 50 символів")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не вказано побатькові працівника")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Поле \"Побатькові\": Довжина повинна бути від 5 до 50 символів")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Не вказана посада працівника")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Поле \"Посада\": Довжина повинна бути від 5 до 200 символів")]
        public string Post { get; set; }
        [Range(1, 9999, ErrorMessage = "Поле \"Індех сортування в табелі\": Значення повинно бути в діапазоні від 1 до 9999")]
        public int OrderNum { get; set; }
        public bool IsArchive { get; set; }

    }
    #endregion

    #region Контекст даних
    public class TableModel : DbContext
    {
        static TableModel()
        {
            Database.SetInitializer<TableModel>(new AppUserContextInitializer());
        }

        public TableModel()
            : base("name=TableModel")
        {
        }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
#endregion

}