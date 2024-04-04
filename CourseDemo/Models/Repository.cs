using System.Collections.Generic;

namespace CourseDemo.Models
{
    public static class Repository
    {
        private static List<Candidate> _applications = new(); // Alan adı değiştirildi

        public static IEnumerable<Candidate> Applications => _applications; // Özellik adı büyük harfle başlatıldı

        public static void Add(Candidate candidate)
        {
            _applications.Add(candidate); // Alan erişim değiştirildi
        }
    }
}
