package algos

import (
	"AlgorithmsGo/helpers"
)

type AStar struct {
}

type Position struct {
	X int
	Y int
}

type Node struct {
	X      int
	Y      int
	G      int
	H      int
	Parent *Node
}

func (n Node) F() int {
	return n.H + n.G
}

func Create(x int, y int) Node {
	return Node{X: x, Y: y}
}

func FindPath(grid [][]int, start Position, goal Position) []*Position {
	var rows int = len(grid)
	var cols int = len(grid[0])

	var dx []int = []int{-1, 0, 1, -1, 1, -1, 0, 1}
	var dy []int = []int{-1, -1, -1, 0, 0, 1, 1, 1}

	openSet := make([]*Node, 0)
	closedSet := make([]*Node, 0)

	startNode := &Node{X: start.X, Y: start.Y}
	goalNode := &Node{X: goal.X, Y: goal.Y}

	openSet = append(openSet, startNode)

	for len(openSet) > 0 {
		current := openSet[0]

		for i := 1; i < len(openSet); i++ {
			if openSet[i].F() < current.F() || (openSet[i].F() == current.F() && openSet[i].H < current.H) {
				current = openSet[i]
			}
		}

		openSet = helpers.Remove(openSet, current)
		closedSet = append(closedSet, current)

		if current.X == goalNode.X && current.Y == goalNode.Y {
			path := make([]*Position, 0)
			node := current
			for node != nil {
				path = append(path, &Position{X: node.X, Y: node.Y})
				node = node.Parent
			}
			return path
		}

		for i := 0; i < 8; i++ {
			newX := current.X + dx[i]
			newY := current.Y + dy[i]

			if newX < 0 || newX >= rows || newY < 0 || newY >= cols || grid[newX][newY] == 1 {
				continue
			}

			neighbor := Node{X: newX, Y: newY}
			neighbor.G = current.G + 1

			neighbor.H = (newX - goalNode.X) + (newY - goalNode.Y)

			if helpers.Contains(closedSet, &neighbor) {
				continue
			}

			if !helpers.Contains(openSet, &neighbor) || neighbor.G < current.G {
				neighbor.Parent = current
				if !helpers.Contains(openSet, &neighbor) {
					openSet = append(openSet, &neighbor)
				}
			}

		}

	}

	return nil
}
