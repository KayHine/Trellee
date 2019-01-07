using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Trellee.Models;

namespace Trellee.DAL
{
    public class TrelleeInitalizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrelleeContext>
    {
        protected override void Seed(TrelleeContext context)
        {
            var cards = new List<Card>
            {
                new Card
                {
                    ID = 1,
                    Title = "Do Homeworkd",
                    Description = "Biology",
                    Sequence = 1,
                    SwimLaneID = 1
                },
                new Card
                {
                    ID = 2,
                    Title = "Practice guitar",
                    Description = "Pentatonic Scales",
                    Sequence = 2,
                    SwimLaneID = 1
                },
                new Card
                {
                    ID = 3,
                    Title = "Build Trellee",
                    Description = "Complete Data Model",
                    Sequence = 1,
                    SwimLaneID = 2
                }
            };
            cards.ForEach(s => context.Cards.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {

            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var boards = new List<Board>
            {

            };
            boards.ForEach(s => context.Boards.Add(s));
            context.SaveChanges();

            var swimLanes = new List<SwimLane>
            {

            };
            swimLanes.ForEach(s => context.SwimLanes.Add(s));
            context.SaveChanges();

            var boardSubscriptions = new List<BoardSubscriptions>
            {

            };
            boardSubscriptions.ForEach(s => context.BoardSubscriptions.Add(s));
            context.SaveChanges();
        }
    }
}
