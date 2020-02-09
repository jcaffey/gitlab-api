define HEREDOC
i am
some multi line
input
endef

export HEREDOC

# shell equivalent of:
#
# cat <<EOF | dotnet run
# i am
# multi
# line
# input
# EOF
heredoc:
	echo "$$HEREDOC" | dotnet run	