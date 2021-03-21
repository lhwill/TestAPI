using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    //ef core 使用codeFirst迁移生成数据库
    //在程序包管理器控制台依次执行以下命令
    //Add-Migration Init  //其中Init是你的版本名称
    //update-database Init //更新数据库操作 init为版本名称
    public class StudentContext:DbContext
    {
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options):base(options) { }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
