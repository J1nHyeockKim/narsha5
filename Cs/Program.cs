using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager Emm = new EmployeeManager();
            do
            {
                Console.WriteLine("1: 사원 등록 2: 사원 삭제 3: 부서 변경 4: 사원 한명 검색 5: 사원 전체 검색 \n그외 프로그램 종료");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Emm.addEmployee();
                        break;
                    case 2:
                        Emm.deleteEmployee();
                        break;
                    case 3:
                        Emm.changeEmployee();
                        break;
                    case 4:
                        Emm.searchEmployeeOne();
                        break;
                    case 5:
                        Emm.searchEmployeeAll();
                        break;
                    default:
                        Console.WriteLine("프로그램을 종료 합니다.");
                        return;
                }
            } while (true);
        }
    }

    public class Employee
    {
        public int personeNum { get; set; }
        public string personeName { get; set; }
        public string phonenum { get; set; }

        private string _department = null;
        public string department {
            get
            {
                return _department;
            }

            set
            {
                switch (_department = value)
                {
                    case "인사팀":
                        _department = value;
                        break;
                    case "개발팀":
                        _department = value;
                        break;
                    case "디자인팀":
                        _department = value;
                        break;
                    default:
                        Console.WriteLine("Error, 부서가 잘못 되었습니다.");
                        break;
                }
            }
        }
        public string address { get; set; }

        public string date { get; set; }

    }
    class EmployeeManager
    {
        List<Employee> list = new List<Employee>();

        public void addEmployee()

        {
            Console.WriteLine("사원을 추가합니다.");
            Employee temp = new Employee();

            Console.WriteLine("사원 번호를 입력해주세요.");
            temp.personeNum = int.Parse(Console.ReadLine());

            Console.WriteLine("사원 이름을 입력해주세요.");
            temp.personeName = Console.ReadLine();

            Console.WriteLine("사원의 전화번호를 입력해주세요.");
            temp.phonenum = Console.ReadLine();

            Console.WriteLine("사원의 부서를 입력해주세요.");
            Console.WriteLine("1: 인사팀, 2: 개발팀, 3: 디자인팀 그외 취소");
            int department = int.Parse(Console.ReadLine());
            switch (department)
            {
                case 1:
                    temp.department = "인사팀";
                    break;
                case 2:
                    temp.department = "개발팀";
                    break;
                case 3:
                    temp.department = "디자인팀";
                    break;
                default:
                    Console.WriteLine("부서를 확인 할 수 없습니다.");
                    break;
            }
            Console.WriteLine("사원의 주소를 입력해주세요.");
            temp.address = Console.ReadLine();

            Console.WriteLine("사원의 입사날짜를 입력해주세요.");
            temp.date = Console.ReadLine();

            list.Add(temp);
        }
        public void deleteEmployee()
        {
            int employeenum;
            Console.WriteLine("사원을 삭제합니다. \n사원 번호를 입력해주세요.");
            employeenum = int.Parse(Console.ReadLine());

            foreach (Employee temp in list)
            {
                if (temp.personeNum==employeenum)
                {
                    Console.WriteLine("정말로 삭제하시겠습니까? y/n");
                    string check = Console.ReadLine();
                    if (check=="y" || check == "Y")
                    {
                        GC.SuppressFinalize(temp);
                    }
                    return;
                }
            }
            Console.WriteLine("사원을 찾을 수 없습니다");
        }
        public void changeEmployee()
        {
            Console.WriteLine("부서를 변경 합니다. \n사원 번호를 입력해주세요.");
            int employeeNum = int.Parse(Console.ReadLine());

            foreach (Employee temp in list)
            {
                if (temp.personeNum == employeeNum)
                {
                    Console.WriteLine("1: 인사팀, 2: 개발팀, 3: 디자인팀");
                    int department = int.Parse(Console.ReadLine());
                    switch (department)
                    {
                        case 1:
                            Console.WriteLine("사원번호 : {0} {1} 을(를) 인사팀으로 변경 합니다.", employeeNum, temp.personeNum);
                            temp.department = "인사팀";
                            break;
                        case 2:
                            Console.WriteLine("사원번호 : {0} {1} 을(를) 개발팀으로 변경 합니다.", employeeNum, temp.personeNum);
                            temp.department = "개발팀";
                            break;
                        case 3:
                            Console.WriteLine("사원번호 : {0} {1} 을(를) 디자인팀으로 변경 합니다.", employeeNum, temp.personeNum);
                            temp.department = "디자인팀";
                            break;
                        default:
                            Console.WriteLine("부서를 확인 할 수 없습니다.");
                            break;

                    }
                    return;
                }
            }
            Console.WriteLine("사원을 찾을 수 없습니다");
        }
        public void searchEmployeeOne()
        {
            int employeenum;
            Console.WriteLine("사원을 조회합니다. \n사원 번호를 입력해주세요.");
            employeenum = int.Parse(Console.ReadLine());

            foreach (Employee temp in list)
            {
                if (temp.personeNum == employeenum)
                {
                    Console.WriteLine("사원번호 : " + temp.personeNum);
                    Console.WriteLine("사원이름 : " + temp.personeName);
                    Console.WriteLine("전화번호 : " + temp.phonenum);
                    Console.WriteLine("부서 : " + temp.department);
                    Console.WriteLine("주소 : " + temp.address);
                    Console.WriteLine("입사일 : " + temp.date);

                    return;
                }
            }
            Console.WriteLine("사원을 찾을 수 없습니다");
        }
        public void searchEmployeeAll()
        {
            foreach (Employee temp in list)
            {
                Console.WriteLine("사원번호 : " + temp.personeNum);
                Console.WriteLine("사원이름 : " + temp.personeName);
                Console.WriteLine("전화번호 : " + temp.phonenum);
                Console.WriteLine("부서 : " + temp.department);
                Console.WriteLine("주소 : " + temp.address);
                Console.WriteLine("입사일 : " + temp.date);
                Console.WriteLine();
            }
        } 
    }
}
