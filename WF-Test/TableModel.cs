namespace WF_Test
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;


    #region ����������� ���� �����
    class AppUserContextInitializer : DropCreateDatabaseAlways<TableModel>
    //class AppUserContextInitializer : DropCreateDatabaseIfModelChanges<TableModel>
    {
        protected override void Seed(TableModel db)
        {
            //���� COLLATE ���� "����" ��� ���������� ������� �������
            db.Database.ExecuteSqlCommand("ALTER TABLE AppUsers ALTER COLUMN Login NVARCHAR(64) COLLATE Latin1_General_CS_AS NOT NULL");

            AppUser _user1 = new AppUser
            {
                Login = "admin",
                Password = "6CBBB93A0AD570EEE7E40BE52AB393E8",
                Salt = "2ABHYDFGXR",
                Name = "�������� ����������� �������",
                IsActive = true
            };

            AppUser _user2 = new AppUser
            {
                Login = "angelA",
                Password = "1D2CA7ED34B7351F4F99B0ACF847622F",
                Salt = "ULB82IJAVQ",
                Name = "�������� ������ ³�������",
                IsActive = true
            };

            db.AppUsers.Add(_user1);
            db.AppUsers.Add(_user2);

            Worker _worker1 = new Worker
            {
                FirstName = "�������",
                LastName = "�����",
                MiddleName = "��������",
                Post = "�����",
                OrderNum = 4,
                IsArchive = false
            };

            Worker _worker2 = new Worker
            {
                FirstName = "��������",
                LastName = "��������",
                MiddleName = "�����������",
                Post = "������� ������ ����",
                OrderNum = 1,
                IsArchive = false
            };

            Worker _worker3 = new Worker
            {
                FirstName = "�������",
                LastName = "������",
                MiddleName = "���������",
                Post = "�������� �������� ��������",
                OrderNum = 3,
                IsArchive = false
            };

            Worker _worker4 = new Worker
            {
                FirstName = "ǳ������",
                LastName = "������",
                MiddleName = "�����������",
                Post = "�����",
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

    #region ���� AppUser
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
    
    #region ���� Worker
    public class Worker
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "�� ������� ������� ����������")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "���� \"�������\": ������� ������� ���� �� 2 �� 50 �������")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "�� ������� ��'� ����������")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "���� \"��'�\": ������� ������� ���� �� 2 �� 50 �������")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "�� ������� ��������� ����������")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "���� \"���������\": ������� ������� ���� �� 5 �� 50 �������")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "�� ������� ������ ����������")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "���� \"������\": ������� ������� ���� �� 5 �� 200 �������")]
        public string Post { get; set; }
        [Range(1, 9999, ErrorMessage = "���� \"����� ���������� � �����\": �������� ������� ���� � ������� �� 1 �� 9999")]
        public int OrderNum { get; set; }
        public bool IsArchive { get; set; }

    }
    #endregion

    #region �������� �����
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