using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooms.API.Data
{
    public static class RoomInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var rooms = new List<Room>()
                {
                    new Room
                    {
                        Id = 1,
                        Name = "DIAMOND HEIST",
                        Address = "New York",
                        Company = "Intercity",
                        Description = "Think you’ve got what it takes to be the world’s greatest thief?",
                        Duration = "60m",
                        LevelOfDifficulty = 3,
                        LevelOfFear = 1,
                        MinAge = 12,
                        MinCountGamers = 1,
                        PhoneNumber = "0123456789",
                        Rating = 1,
                        PictureUrl = "https://m.economictimes.com/thumb/msid-60217597,width-1200,height-900,resizemode-4,imgsize-73839/the-untold-story-of-a-100mn-diamond-heist-and-how-it-happened.jpg"
                    },
                    new Room
                    {
                        Id = 2,
                        Name = "CURSED CASTLE",
                        Address = "St. Lois",
                        Company = "King",
                        Description = "Can you save the kingdom from eternal darkness?",
                        Duration = "60m",
                        LevelOfDifficulty = 5,
                        LevelOfFear = 1,
                        MinAge = 10,
                        MinCountGamers = 5,
                        PhoneNumber = "213456789",
                        Rating = 5,
                        PictureUrl = "https://images-na.ssl-images-amazon.com/images/I/91hTjrrFYIL.jpg"
                    },
                    new Room
                    {
                        Id = 3,
                        Name = "SECRET SOCIETY",
                        Address = "New York",
                        Company = "King",
                        Description = "Will you survive the trials of a Secret Society’s initiation?",
                        Duration = "120m",
                        LevelOfDifficulty = 4,
                        LevelOfFear = 3,
                        MinAge = 16,
                        MinCountGamers = 5,
                        PhoneNumber = "123456789",
                        Rating = 3,
                        PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/2/24/Secret_Society_Buildings_New_Haven.jpg"
                    },
                    new Room
                    {
                        Id = 4,
                        Name = "DAVINCI’S WORKSHOP",
                        Address = "St. Lois",
                        Company = "King",
                        Description = "Can you save the Mona Lisa from burglars?",
                        Duration = "80m",
                        LevelOfDifficulty = 2,
                        LevelOfFear = 1,
                        MinAge = 10,
                        MinCountGamers = 2,
                        PhoneNumber = "123456789",
                        Rating = 5,
                        PictureUrl = "https://i.pinimg.com/originals/32/35/b0/3235b03626e8bf3baf3accd7399df06c.jpg"
                    },
                    new Room
                    {
                        Id = 5,
                        Name = "HOME ALONE",
                        Address = "Chicago",
                        Company = "King",
                        Description = "Ready to defend your home from the Wet Bandits?",
                        Duration = "60m",
                        LevelOfDifficulty = 5,
                        LevelOfFear = 4,
                        MinAge = 10,
                        MinCountGamers = 4,
                        PhoneNumber = "987654310",
                        Rating = 5,
                        PictureUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWCBy0UhjPAQW8vS-Iif6T6g371tYQktlEPQ&usqp=CAU"
                    }
                };

            modelBuilder.Entity<Room>().HasData(rooms);

            //var pictures = new List<RoomPicture>()
            //{
            //    new RoomPicture {RoomId = 1, Url = ""},
            //    new RoomPicture {RoomId = 1, Url = "https://static.dw.com/image/16610618_303.jpg"},

            //    new RoomPicture {RoomId = 2, Url = ""},
            //    new RoomPicture {RoomId = 2, Url = "https://live.staticflickr.com/65535/50109449243_485c41d1da_o.jpg"},

            //    new RoomPicture {RoomId = 3, Url = ""},
            //    new RoomPicture {RoomId = 3, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/%E5%8E%A6%E9%97%A8%E6%B4%AA%E9%97%A8%E8%85%B0%E7%89%8C.JPG/800px-%E5%8E%A6%E9%97%A8%E6%B4%AA%E9%97%A8%E8%85%B0%E7%89%8C.JPG"},

            //    new RoomPicture {RoomId = 4, Url = ""},
            //    new RoomPicture {RoomId = 4, Url = "https://images.squarespace-cdn.com/content/v1/537b49fee4b0a7ee8ea2bad5/1505700410505-N7OMXKCL5VZZDJGBVJLF/ke17ZwdGBToddI8pDm48kJ5EHYcY28NaWUS30lJdMjh7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QHyNOqBUUEtDDsRWrJLTm84Pw0V_eohN38mBwAxGEj2BTlhPxRdjttxu0B6e37Kz9GWAtipaC5wMn6LmVgKnU/Manbase.AJ_.png"},

            //    new RoomPicture {RoomId = 4, Url = ""},
            //    new RoomPicture {RoomId = 4, Url = "https://i.insider.com/5fb3c9b8a789db2cc15a513e?width=700"},
            //};

            //modelBuilder.Entity<RoomPicture>().HasData(pictures);
        }
    }
}
