arr = [1, 5, 8, 4, 6, 1, 2]

Find the largest element of arr without using arr.Sort().

Output: The largest element is: 8.
===============================================================================

arr = [1, 5, 8, 4, 6, 1, 2]
max_element = arr[0]

for num in arr:
    if num > max_element:
        max_element = num
print("The largest element is:", max_element)