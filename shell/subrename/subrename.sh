if [ $# -ne 2 ]; then
	echo "--- need argument ---";
	exit 1;
fi
if [[ $1 == *"\\"* ]]; then 
	echo "--- path cannot contains \\ ---";
	exit 1;
fi
if [[ $2 == *"\\"* ]]; then 
	echo "--- path cannot contains \\ ---";
	exit 1;
fi

if [[ ! -d $1 || ! -d $2 ]]; then
	echo "--- path does not exist\\ ---";
	exit 1;
fi

IFS=$'\n'

root=`realpath ${0%/*}`
log=$root/`date '+%Y_%m_%d_%H_%M_%S'`.log

cd $1;

origin=(`ls`);

echo ${origin[*]}>`expr $log`
echo "---">>`expr $log`
echo "origin files:"
for i in ${origin[*]};do
	echo "  "$i
done
echo

echo "origin length is `ls | wc -l`"

cd ..
cd $2;
sub=(`ls`);
echo ${sub[*]}>>`expr $log`
echo "sub files:"
for i in ${sub[*]}; do
	echo "  "$i;
done
echo "sub length is `ls | wc -l`"
echo

if [ ${#origin[*]} != ${#sub[*]} ]; then
	echo "---- file num do not equal ---";
	exit 1;
fi

for((i=0;i<`expr ${#sub[*]}`;i++));do
	echo ${sub[`expr $i`]};
	echo ${origin[`expr $i`]%.*}
	mv ${sub[`expr $i`]} ${origin[`expr $i`]%.*}.srt
done
echo result $?;