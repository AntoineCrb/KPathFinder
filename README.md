
# KPathfinder

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

## Description :

KPathfinder is a pathfinding algorithm designed for performance.
It's based on the AStar algorithm with a considerable performance improvement in some specific cases.
KPathfinder is an opensource project, made for fun and skill improvements, it will stay as is.


## Performance Tests : 

|  Path length  |  Obstacles  |  KPathfinder | AStar  | Ratio |
| --- | --- | --- | --- | --- |
| 5  | No  | 28,6μs  | 118,9μs  | 4.15 times faster |
| 500  | No  | 66,6μs |  83ms | 1246 times faster |
| 500  | Yes  | 86ms  |  85ms | 0.99 times slower |

**Hardware** : CPU Intel Core i3-6100, 12GB RAM DDR4

**Note**: Every test have been realised 100 times, the result was then divided by 100. The AStar algorithm used is the same as the one implemented in the KPathfinder.


## How does it work ?

The KPathfinder works by searching a straight path to the destination instead of checking every nodes encounter and their neighbors which is done in the **AStar**.

<img src="https://s2.gifyu.com/images/astar.gif" height="256px"></img><img src="https://s2.gifyu.com/images/KPathfinder.gif" height="256px"  align="right"></img>

However, if the direct path encounter a wall, it just restart the search from the start but with an **AStar** algorithm instead.

As a result, the **KPathfinder** can be significantly faster than the **AStar** algorithm in some cases and it will be as accurate as it.


## When should you used the KPathfinder ?

The **KPathfinder** has been made to answer **performance issues** on a specific case.

The **KPathfinder** is extremely fast if the path hasn't any obstacle. It must therefore be used if the map does **not present many obstacles** or if there are **many requests for short path**.

For instance, if you have a map like that, using the **KPathfinder** will be able to increase your performance drastically, as you can see in the performance test, it can be up to 1000 times faster than the **AStar** algorithm.
<img src="https://i.ibb.co/pLbYg6t/KPath-map.jpg" height="550px">
*this type of map is common in many games*


## Requirements :
> [.NET Core SDK 2.2+](https://www.microsoft.com/net/download)


## Credits
### Authors : 
- Kraken

### Special Thanks :
- Blowa


If you found this repository useful or interesting do not hesitate to star it :smiley: