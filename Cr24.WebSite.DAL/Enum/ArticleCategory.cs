using System;

namespace Cr24.WebSite.DAL.Enum
{
    public enum ArticleCategory
    {
        CreditScoring,
        CreditRating
    }

    public static class ArticleCategoryHelper
    {
        public static string ToPersian(this ArticleCategory article)
        {
            switch (article)
            {
                case ArticleCategory.CreditScoring:
                    return "اعتبارسنجی";
                case ArticleCategory.CreditRating:
                    return "رتبه بندی";
                default:
                    throw new ArgumentOutOfRangeException(nameof(article), article, null);
            }
        }
    }
}
