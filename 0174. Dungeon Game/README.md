# Binary Search Tree Iterator

The demons had captured the princess (__P__) and imprisoned her in the bottom-right corner of a dungeon. The dungeon consists of M x N rooms laid out in a 2D grid. Our valiant knight (__K__) was initially positioned in the top-left room and must fight his way through the dungeon to rescue the princess.

The knight has an initial health point represented by a positive integer. If at any point his health point drops to 0 or below, he dies immediately.

Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; other rooms are either empty (0's) or contain magic orbs that increase the knight's health (positive integers).

In order to reach the princess as quickly as possible, the knight decides to move only rightward or downward in each step.

__Write a function to determine the knight's minimum initial health so that he is able to rescue the princess.__

For example, given the dungeon below, the initial health of the knight must be at least 7 if he follows the optimal path `RIGHT-> RIGHT -> DOWN -> DOWN`.

<table style="border: 3px solid black;">
	<tbody>
		<tr>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">-2 (K)</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">-3</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">3</td>
		</tr>
		<tr>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">-5</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">-10</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">1</td>
		</tr>
		<tr>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">10</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">30</td>
			<td style="text-align: center; height: 70px; width: 70px; border: 3px solid black;">-5 (P)</td>
		</tr>
	</tbody>
</table>

__Note:__

- The knight's health has no upper bound.
- Any room can contain threats or power-ups, even the first room the knight enters and the bottom-right room where the princess is imprisoned.