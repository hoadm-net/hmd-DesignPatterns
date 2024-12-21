namespace _01_Overview;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        // Sử dụng property để thiết lập giá trị cho field
        student.StudentID = "S123456";
        student.Name = "Alice";
        student.Age = 20;

        // Gọi method để hiển thị thông tin sinh viên
        student.DisplayInfo();
    }
}