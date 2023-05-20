
namespace GrantFoods.ViewModels
{
    public partial class LandingViewModel : BaseViewModel
    {
        readonly LandingPageService landingPageService;

        public LandingViewModel(LandingPageService _landingPageService)
        {
            landingPageService = _landingPageService;

            LoadData();
        }

        public ObservableCollection<string> ArtCollection01 { get; set; }
        public ObservableCollection<string> ArtCollection02 { get; set; }
        public ObservableCollection<string> ArtCollection03 { get; set; }

        [RelayCommand]
        void LoadMoreArtCollection01()
        {
            var artCollection01 = landingPageService.GetArtCollection01();

            foreach (var artItem in artCollection01)
            {
                ArtCollection01.Add(artItem);
            }
        }

        [RelayCommand]
        void LoadMoreArtCollection02()
        {
            var artCollection02 = landingPageService.GetArtCollection02();

            foreach (var artItem in artCollection02)
            {
                ArtCollection02.Add(artItem);
            }
        }

        [RelayCommand]
        void LoadMoreArtCollection03()
        {
            var artCollection03 = landingPageService.GetArtCollection03();

            foreach (var artItem in artCollection03)
            {
                ArtCollection03.Add(artItem);
            }
        }

        void LoadData()
        {
            ArtCollection01 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection01 = landingPageService.GetArtCollection01();

                foreach (var artItem in artCollection01)
                {
                    ArtCollection01.Add(artItem);
                }
            }

            ArtCollection02 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection02 = landingPageService.GetArtCollection02();

                foreach (var artItem in artCollection02)
                {
                    ArtCollection02.Add(artItem);
                }
            }

            ArtCollection03 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection03 = landingPageService.GetArtCollection03();

                foreach (var artItem in artCollection03)
                {
                    ArtCollection03.Add(artItem);
                }
            }
        }
    }
}
