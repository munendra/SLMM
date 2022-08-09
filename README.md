# SLMM

#### Url: https://localhost:44318/slmm/lawntask
#### Type: Post
#### Body:
```json

{
  "lawn": {
  "width": 20,
  "length": 10
},
  "mowingMachine": {
  "position": {
    "x": 0,
    "y": 0
  },
        "moveTo": 90
},
  "actions": 2
}
```
---
"actions": Actions having 3 following actions which can pass as a parameters

    0: rotate 90 degree clockwise
    1:rotate 90 degree anticlockwise
    2:Move one step forward


---
"moveTo": Having 4 option which are the following.

    North=0,
    East=90,
    South=180,
    West=270



