if [ $# -ne 1 ]; then
	echo "--- need argument ---";
	exit 1;
fi
if [[ $1 == *"\\"* ]]; then 
	echo "--- path cannot contains \\ ---";
	exit 1;
fi

if [[ ! -d $1 ]]; then
	echo "--- path does not exist\\ ---";
	exit 1;
fi

IFS=$'\n'

root=`realpath ${0%/*}`

cd $1;

origin=(*);

echo "origin files:"
for i in ${origin[*]};do
	echo "  "$i
done

read -p "confirm zip?" yn
case $yn in
	[Yy]* ) ;;
	[Nn]* ) exit;;
	* ) exit;;
esac

for i in ${origin[*]};do
	 /c/Software/7-Zip/7z.exe a $i.zip $i
done

echo "origin length is "${#origin[*]}


echo result $?;