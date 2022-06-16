﻿namespace Collections.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CollectionId  { get; set; }

        public AppCollection Collection { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
