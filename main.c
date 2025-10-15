#include <stdio.h>
#include <dirent.h>
#include <errno.h>
#include <stdlib.h>

int main(void) {
    struct dirent *de; //pointer for directory entry

    DIR *dr = opendir("C:\\Users\\swive");

    if (dr == NULL) {
        printf("Could not open directory: %s\n", strerror(errno));
        exit(-1);
    }

    //for readdir()
    while ((de = readdir(dr)) != NULL) {
        printf("%s\n", de->d_name);
    }
    closedir(dr);

    puts("Done!");
    return 0;
}
