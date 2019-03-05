# The guess API is already defined for you.
# @param num, your guess
# @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
# def guess(num):


class Solution(object):
    def guessNumber(self, n):
        """
        :type n: int
        :rtype: int
        """
        return self.guess_core(1, n)

    def guess_core(self, left, right):
        """
        :type left: int
        :type right: int
        :rtype: int
        """
        mid = (left + right) / 2
        next = guess(mid)
        if next == -1:
            return self.guess_core(left, mid - 1)
        elif next == 1:
            return self.guess_core(mid + 1, right)
        else:
            return mid
