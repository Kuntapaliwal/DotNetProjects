namespace Discussion11
{    
    public class Student
    {
        private int _rollNo;
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        public Student()
        {

        }
        public Student(string name,int rollNo)
        {
            this._name = name;
            this._rollNo = rollNo;
        }

        public override string ToString()
        {
            return base.ToString() + $" [ Name : {_name} \t RollNo : {_rollNo}]";
        }

    }
}