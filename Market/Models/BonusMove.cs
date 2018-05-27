using System;

namespace Market.Models
{
    class BonusMove : Date
    {
        public int id;
        public int sum;
        public int bonusType;
        public int moveType;
        public String firstName;
        public String secondName;
        public String phone;

        public BonusMove(int id, int sum, int bonusType, String firstName, String secondName, String phone, DateTime date, int moveType)
        {
            this.id = id;
            this.sum = sum;
            this.bonusType = bonusType;
            this.moveType = moveType;
            this.firstName = firstName;
            this.secondName = secondName;
            this.phone = phone;
            this.date = date;
        }

        public string getMoveTypeAsString()
        {
            if (moveType == 1)
            {
                return "Перевод";
            }
            if (moveType == 2)
            {
                return "Списание";
            }
            if (moveType == 3)
            {
                return "Начисление";
            }
            if (moveType == 4)
            {
                return "Оплата бонусами";
            }

            return "-";
        }
    }
}
