using System;
using System.Collections.Generic;
using Blazor1.Models;

namespace Blazor1.Repository
{
    public class MockPageRepository : IRepository
    {
        List<Page> _games;

        public MockPageRepository()
        {
            _games = new List<Page>()
            {
                new Page()
                {
                    Name = "My first project",
                    Level = "junior",
                    ReleaseDate = new DateTime(2021, 08, 19)
                },
                new Page()
                {
                    Name = "My 108 project",
                    Level = "Still junior",
                    ReleaseDate = new DateTime(2021, 08, 30)
                },
                new Page()
                {
                    Name = "My 1009 project",
                    Level = "Also junior",
                    ReleaseDate = new DateTime(2021, 09, 15)
                }
            };
        }
        public List<Page> GetAllPages()
        {
            return _games;
        }
    }
}