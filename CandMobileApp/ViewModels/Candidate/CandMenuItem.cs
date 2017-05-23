using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CandMobileApp
{
    public enum CandPage
    {
        ThinkingJD,
        ChoosingJD,
        ApplyingJD,
        FinancingJD,
        DiversityJD,
        LLMDegree,
        ChoosingLLM,
        LLMProcess,
        OffGuideJD,
        OffGuideLLM,
        Forums,
        Recriutment,
    };

    public class CandMenuItem
    {

        public CandPage Key
        {
            get;
            set;
        }
        public string ImageName
        {
            get;
            set;
        }
        public string Caption
        {
            get;
            set;
        }
        public string Detail
        {
            get;
            set;
        }
        public string Badge
        {
            get;
            set;
        }
        public CandMenuItem()
        {
        }
    }

    public class GroupedCandMenu : ObservableCollection<CandMenuItem>
    {
        public string GroupKey { get; set; }
    }
}
