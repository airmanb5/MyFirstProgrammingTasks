    class Post
    {
        public Post(string title, string description)
        {
            this.Title = title;

            this.Description = description;

            this.CreationDateTime = DateTime.Now;
        }

        public string Title { get; }

        public string Description { get; }

        public DateTime CreationDateTime { get;  }

        public int VoteValue { get; private set; }

        public void VoteUp()
        {
            VoteValue++;
        }

        public void VoteDown()
        {
            VoteValue--;
        }
    }