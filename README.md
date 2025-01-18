# F# Mutability Bug

This repository demonstrates a common pitfall in F# related to mutable variables and function calls.  The example showcases how reassigning mutable variables outside a function does not automatically update values used *within* a prior function call.

## Bug Description
The code attempts to add two mutable variables (`x` and `y`), storing the sum in `result`.  It then reassigns `x` and `y`, expecting `result` to reflect the new sum upon re-evaluation. This expectation is incorrect, illustrating a misunderstanding of mutable variable behavior in F#.

## Solution
The solution involves using a function that recalculates the sum whenever `x` and `y` change, or leveraging immutable data structures and functional programming techniques.