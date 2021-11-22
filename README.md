
# KPathfinder

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

## Description :

KPathfinder is a pathfinding algorithm designed for performance.
It's based on the AStar algorithm with a considerable performance improvement in some specific cases.
KPathfinder is an opensource project, made for fun and skill improvements, it will stay as is.

In this repository you will be able to find my own implementation of the **A*** algorithm using **C#**, of a MinHeap using a **binary search** and also of the **KPathfinder**.

## Performance Tests : 

|  Path length  |  Obstacles  |  KPathfinder | AStar  | Ratio |
| --- | --- | --- | --- | --- |
| 5  | No  | 0,4μs  | 5,7μs  | 14.25 times faster |
| 500  | No  | 6,4μs |  17,0ms | 2656.25 times faster |
| 500  | Yes  | 16,9ms  |  16,9ms | as fast |

**Hardware** : CPU Intel Core i3-6100, 12GB RAM DDR4

**Note**: Every test have been realised 10000 times, the result was then divided by 10000. The AStar algorithm used is the same as the one implemented in the KPathfinder.


## How does it work ?

The KPathfinder works by searching a straight path to the destination instead of checking every nodes encounter and their neighbors which is done in the **AStar**.

<img src="https://s2.gifyu.com/images/astar.gif" height="256px"></img><img src="https://s2.gifyu.com/images/KPathfinder.gif" height="256px"  align="right"></img>

However, if the direct path encounter a wall, it just restart the search from the start but with an **AStar** algorithm instead.

As a result, the **KPathfinder** can be significantly faster than the **AStar** algorithm in some cases and it will be as accurate as it.


## When should you used the KPathfinder ?

The **KPathfinder** has been made to answer **performance issues** on a specific case.

The **KPathfinder** is extremely fast if the path hasn't any obstacle. It must therefore be used if the map does **not present many obstacles** or if there are **many requests for short path**.

For instance, if you have a map like the one below, using the **KPathfinder** will be able to increase your performance drastically, as you can see in the performance test, it can be up to 2600 times faster than the **AStar** algorithm.

<img src="https://i.ibb.co/pLbYg6t/KPath-map.jpg" height="450px">

*this type of map is common in many games*


## Requirements :
> [.NET Core SDK 2.2+](https://www.microsoft.com/net/download)


## Credits
### Authors : 
- AntoineCrb

### Special Thanks :
- Blowa


If you found this repository useful or interesting do not hesitate to star it :smiley:
