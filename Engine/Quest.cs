using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int rewardEXP { get; set; }
        public int rewardGold { get; set; }
        public Item rewardItem { get; set; }
        public List<QuestCompletionItem> completionItems { get; set; }

        public Quest (int questID, string questName, string questDescription, int questRewardEXP, int questRewardGold)
        {
            ID = questID;
            name = questName;
            description = questDescription;
            rewardEXP = questRewardEXP;
            rewardGold = questRewardGold;
            completionItems = new List<QuestCompletionItem>();
        }

    }
}
