﻿using Lab4.Utils;
using Lab4.Views;
using System;
using System.Collections.Generic;

namespace Lab4.Model.Tasks.Individual.IndividualTasksB
{
    class IndividualB3
    {
        public string Run()
        {
            ExtractForTasks extract = new ExtractForTasks(InputService.GetInstance(), OutputService.GetInstance());
            const int Zero = 0,
                One = 1;
            int[] arrValue = extract.IndividualB3();
            int indexAdvantage = arrValue[Zero],
                indexSuits = arrValue[One];
            return IndividualTaskB3(indexAdvantage, indexSuits);
        }
        public static string IndividualTaskB3(int indexAdvantage, int indexSuits)
        {
            Dictionary<int, string> cardSuits = new Dictionary<int, string>
            {
                { 1, "peaks" },
                { 2, "club" },
                { 3, "diamond"},
                { 4, "hearts"}
            };
            Dictionary<int, string> cardAdvantage = new Dictionary<int, string> {
                { 6, "Six" },
                { 7, "Seven"},
                { 8, "Eight"},
                { 9, "Nine"},
                { 10, "Ten"},
                { 11, "Eleven"},
                { 12, "twelve"},
                { 13, "thirteen"},
                { 14, "Chetyrnadcati"},
            };
            const int StartKeyAdvantage = 6,
                StartKeySuits = 1;
            int countCardAdvantage = cardAdvantage.Count,
                countCardSuits = cardSuits.Count;
            if (indexAdvantage < StartKeyAdvantage && indexAdvantage > countCardAdvantage ||
                indexSuits < StartKeySuits && indexSuits > countCardSuits)
            {
                throw new Exception("Error, invalid data.Transfer data from 0 to 10");
            }
            return cardAdvantage[indexAdvantage + StartKeyAdvantage] + " " + cardSuits[indexSuits + StartKeySuits];
        }
    }
}
