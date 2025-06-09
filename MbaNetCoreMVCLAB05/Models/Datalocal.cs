namespace MbaNetCoreMVCLAB05.Models
{
    public class DataLocal
    {
        private readonly List<MbaPeople> _peoples;

        public DataLocal()
        {
            _peoples = new List<MbaPeople>
        {
            new MbaPeople
            {
                MbaID = 0,
                MbaName = "Mai Binh An",
                MbaEmail = "Mba01@gmail.com",
                MbaPhone = "09471248812",
                MbaAddress = "HN",
                MbaAvatar = "C:\\ASPNET\\image\\Avt-Mai An.jpg",
                MbaBirthday = Convert.ToDateTime("2005/01/03"),
                MbaBio = "Mban",
                MbaGender = 0
            },
            new MbaPeople
            {
                MbaID = 1,
                MbaName = "Trịnh Văn Chung",
                MbaEmail = "chungtrinh@gmail.com",
                MbaPhone = "0978611889",
                MbaAddress = "25 Vũ Ngọc Phan",
                MbaAvatar = "C:\\ASPNET\\image\\Avt-Trung Chịnh.jpg",
                MbaBirthday = Convert.ToDateTime("1979/05/25"),
                MbaBio = "Devmaster Academy",
                MbaGender = 1
            },
            new MbaPeople
            {
                MbaID = 2,
                MbaName = "Nguyễn Duy",
                MbaEmail = "Duynguyen@gmail.com",
                MbaPhone = "09144411311",
                MbaAddress = "Gia Lâm, Hà Nội",
                MbaAvatar = "/images/MbaAvatar/02.jpg",
                MbaBirthday = Convert.ToDateTime("1999/02/12"),
                MbaBio = "Học viên Devmaster",
                MbaGender = 1
            },
            new MbaPeople
            {
                MbaID = 3,
                MbaName = "Tiểu Long Nữ",
                MbaEmail = "longnuqualtue@gmail.com",
                MbaPhone = "09004001002",
                MbaAddress = "Ba Đình, Hà Nội",
                MbaAvatar = "/images/MbaAvatar/03.jpg",
                MbaBirthday = Convert.ToDateTime("2000/02/02"),
                MbaBio = "Nhân vật trong phim kiếm hiệp",
                MbaGender = 2
            },
            new MbaPeople
            {
                MbaID = 4,
                MbaName = "Pikachu",
                MbaEmail = "chupika@gmail.com",
                MbaPhone = "0902114115",
                MbaAddress = "Quảng Trường, Hà Đông",
                MbaAvatar = "/images/MbaAvatar/04.jpg",
                MbaBirthday = Convert.ToDateTime("1997/12/12"),
                MbaBio = "Nhân vật trong phim hoạt hình",
                MbaGender = 2
            }
        };
        }

        public void Add(MbaPeople model)
        {
            model.MbaID = _peoples.Any() ? _peoples.Max(p => p.MbaID) + 1 : 1; // Tạo ID tự động
            _peoples.Add(model);
        }

        public void Update(MbaPeople model)
        {
            var existing = _peoples.FirstOrDefault(p => p.MbaID == model.MbaID);
            if (existing != null)
            {
                _peoples.Remove(existing);
                _peoples.Add(model);
            }
        }

        public void Remove(MbaPeople model)
        {
            _peoples.Remove(model);
        }

        public async Task SaveChangesAsync()
        {
            // Giả lập lưu dữ liệu (danh sách đã được cập nhật trong Add/Update/Remove)
            await Task.CompletedTask;
        }

        public List<MbaPeople> GetMbaPeoples()
        {
            return _peoples;
        }

        public MbaPeople GetMbaPeopleByMbaID(int id)
        {
            return _peoples.FirstOrDefault(p => p.MbaID == id);
        }
    }
}