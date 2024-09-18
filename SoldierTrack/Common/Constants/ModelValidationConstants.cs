﻿namespace SoldierTrack.Web.Common.Constants
{
    public static class ModelValidationConstants
    {
        public static class AthleteConstants
        {
            public const int NamesMinLength = 2;
            public const int NamesMaxLength = 50;

            public const int PhoneLength = 10;

            public const int EmailMinLength = 5;
            public const int EmailMaxLength = 100;


            public const int UserIdLength = 36;
        }

        public static class WorkoutConstants
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 50;

            public const int BriefDescriptionMinLength = 10;
            public const int BriefDescriptionMaxLength = 100;

            public const int FullDescriptionMinLength = 50;
            public const int FullDescriptionMaxLength = 2_000;

            public const int ImageUrlMinLength = 10;
            public const int ImageUrlMaxLength = 255;

            public const int ParticipantsMinValue = 1;
            public const int ParticipantsMaxValue = 15;

            public const int CurrentParticipantsMinValue = 0;
        }
    }
}
