namespace CancerInstApi.BusinessLogic
{
    public interface IPalindromeLogic
    {
        string DoReverse(string s);
        bool IsPalindrome(string phrase);
        string Sanitize(string phrase);
    }
}