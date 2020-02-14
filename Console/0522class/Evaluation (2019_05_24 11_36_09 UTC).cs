using System;

namespace _0522class
{
    public struct Evaluation
    {
        private double midterm;
        private double project;
        private double final;
        private double average()
        {
            double score;
            score = ((midterm * 30) + (Project * 30) + (final * 40)) / 100;
            return score;
        }

        //setter and getter properties
        public double MidTerm
        {
            get => midterm;
            set => midterm = value;
        }

        public double Final
        {
            set => final = value;
            get => final;
        }
        public double Average
        {
            // set => average = ((midterm * 30) + (project * 30) + (final * 40)) / 100;
            get => average();
        }
        public double Project { get => project; set => project = value; }

    };
}
