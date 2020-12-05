#include <stdlib.h>
int main(int argc, char *argv[ ])
{
 char *env;
 char buf[100];
 env = getenv("PATH");
 if ( env == NULL ) { return 0; }
 sprintf(buf, "%s", env);
 return 0;
}