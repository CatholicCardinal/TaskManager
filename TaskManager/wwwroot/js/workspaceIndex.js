const workspaceButtons = document.querySelectorAll('.workspace-button');

workspaceButtons.forEach(button => {
	button.addEventListener('click', () => {
		const functions = button.nextElementSibling;
		if (functions.style.display != 'block') {
			functions.style.display = 'block';
		} else {
			functions.style.display = 'none';
		}
	});
});