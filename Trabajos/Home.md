# Doing
```dataview
table type as Type, tags as Tags
where status = "doing"
where type != "Fleeting Note"
sort priority desc
```
# Ready to process
```dataview
table type as Type, tags as Tags
where status = "ready to process"
sort priority desc
```

# Actual projects
```dataview
table type as Type, tags as Tags
where status = "doing"
where type = "Fleeting Note"
sort priority desc
```
# To-Do
```dataview
table type as Type, tags as Tags
where status = "todo"
sort priority desc
```
