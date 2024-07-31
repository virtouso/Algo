package helpers

import "reflect"

func Remove[T any](slice []T, element T) []T {
	// Iterate through the slice and create a new slice without the element
	var result []T
	for _, item := range slice {
		if !reflect.DeepEqual(item, element) {
			result = append(result, item)
		}
	}
	return result
}

func Contains[T comparable](elems []T, v T) bool {
	for _, s := range elems {
		if v == s {
			return true
		}
	}
	return false
}
