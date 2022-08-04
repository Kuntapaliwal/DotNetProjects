namespace model

{

    public class Worker

    {
        int workerId;
        // Optional<String> lastName;
        String firstName;
        String lastName;
        double salary;
        // Optional<Double> salary;
        string joiningDate;
        String department;
        // Optional<String>department;
        String email;


        public Worker(int workerId, String firstName, String lastName, Double salary,
             string joiningDate, String department, String email)
        {
            this.workerId = workerId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.salary = salary;
            this.joiningDate = joiningDate;
            this.department = department;
            this.email = email;

        }


        public int WorkerId

        {

            get { return workerId; }

            set { workerId = value; }

        }

        public string JoiningDate

        {

            get { return joiningDate; }

            set { joiningDate = value; }

        }

        public string Department

        {

            get { return department; }

            set { department = value; }

        }


        public string Email

        {

            get { return email; }

            set { email = value; }

        }

        //private string firstName;

        public string FirstName

        {

            get { return firstName; }

            set { firstName = value; }

        }

        public string LastName

        {

            get { return lastName; }

            set { lastName = value; }

        }


        public double Salary

        {

            get { return salary; }

            set { salary = value; }

        }



        public String toString()

        {

            return "Worker[department = " + department + ", email = " + email + ", firstName = " + firstName + ", joiningDate = "
                + joiningDate + ", lastName=" + lastName + ", salary=" + salary + ", workerId=" + workerId + "]";

        }

    }

}