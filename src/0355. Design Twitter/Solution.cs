public class Twitter {

    /** Initialize your data structure here. */
    public Twitter () {
        this._tweetsPoster = new Dictionary<int, int> ();
        this._tweets = new List<int> ();
        this._followDict = new Dictionary<int, HashSet<int>> ();
    }

    private IDictionary<int, int> _tweetsPoster;

    private IDictionary<int, HashSet<int>> _followDict;

    private IList<int> _tweets;

    /** Compose a new tweet. */
    public void PostTweet (int userId, int tweetId) {
        this._tweetsPoster.Add (tweetId, userId);
        this._tweets.Add (tweetId);
        this.Follow (userId, userId);
    }

    /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
    public IList<int> GetNewsFeed (int userId) {
        var res = new List<int> ();
        if (!this._followDict.ContainsKey (userId)) {
            return res;
        }
        var followees = this._followDict[userId];
        for (int i = this._tweets.Count - 1; i >= 0 && res.Count < 10; i--) {
            var tweetId = this._tweets[i];
            var poster = this._tweetsPoster[tweetId];
            if (followees.Contains (poster)) {
                res.Add (tweetId);
            }
        }
        return res;
    }

    /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
    public void Follow (int followerId, int followeeId) {
        if (!this._followDict.ContainsKey (followerId)) {
            this._followDict.Add (followerId, new HashSet<int> ());
        }
        this._followDict[followerId].Add (followeeId);
    }

    /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
    public void Unfollow (int followerId, int followeeId) {
        if (followerId == followeeId) {
            return;
        }
        if (this._followDict.ContainsKey (followerId)) {
            this._followDict[followerId].Remove (followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */