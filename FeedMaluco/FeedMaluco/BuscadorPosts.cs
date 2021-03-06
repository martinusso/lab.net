﻿using System;

namespace FeedMaluco
{
    class BuscadorPosts
    {
        private FeedDotNet.Common.Feed Posts;

        public BuscadorPosts(string feedUri)
        {
            Posts = FeedDotNet.FeedReader.Read(feedUri);
        }

        public Post ObterPostAleatorio()
        {
            Random random = new Random();
            int index = random.Next(Posts.Items.Count);
            return new Post(Posts.Items[index].Title, Posts.Items[index].Content);
        }
    }
}
