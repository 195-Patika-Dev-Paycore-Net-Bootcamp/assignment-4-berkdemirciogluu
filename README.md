# Container Optimization Using K-Means
## The Aim of the Project 
A waste collection system consisting of irregular container locations is not realistic and efficient. Vehicles need to collect containers systematically to prevent waste of time and money. Implementing optimization techniques is required to achieve it. The system is improved by using the K-Means clustering technique. 
## K-Means Clustering 
k-means clustering is one of the most common clustering techniques. In k-means clustering, the algorithm attempts to group observations into k groups, with each group having roughly equal variance. The number of groups, k, is specified by the user as a hyperparameter. Specifically, in k-means:
  1. k cluster “center” points are created at random locations. <br>
  2. For each observation: <br>
    a. The distance between each observation and the k center points is calculated. <br>
    b. The observation is assigned to the cluster of the nearest center point. <br>
  3. The center points are moved to the means (i.e., centers) of their respective clusters. <br>
  4. Steps 2 and 3 are repeated until no observation changes in cluster membership. <br>
At this point the algorithm is considered converged and stops. <br> <br>
It is important to note three things about k-means:
- K-means clustering assumes the clusters are convex shaped (e.g., a circle, a sphere). <br>
- All features are equally scaled. <br>
- The groups are balanced (i.e., have roughly the same number of observations). <br>

In pseudo-code, k-means is: <br> <br>
initialize clustering <br>
loop until done <br>
&nbsp; &nbsp; compute mean of each cluster <br>
&nbsp; &nbsp; update clustering based on new means <br>
end loop <br> <br>
Figure 1 represents an initial clustering of data. Visually, each data point is colored red, yellow or green to indicate cluster membership. <br>
resim1 


