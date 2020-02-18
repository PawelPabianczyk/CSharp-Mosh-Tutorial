using System;

namespace exerciseClass
{
    public class Post
    {
        private string _title;
        private DateTime _date;
        private string _description;
        private int _upVote;
        private int _downVote;

        public Post(string title, string description)
        {
            this._date = DateTime.Now;
            this._title = title;
            this._description = description;
            this._downVote = 0;
            this._upVote = 0;
        }

        public void UpVote()
        {
            _upVote++;
        }

        public void DownVote()
        {
            _downVote++;
        }

        public void Voting()
        {
            Console.WriteLine("Up-vote: {0}\nDown-vote: {1}", _upVote, _downVote);
        }
    }
}