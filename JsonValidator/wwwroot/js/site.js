

var editor = CodeMirror.fromTextArea(document.getElementById('json-string'), {
    lineNumbers: true,
    mode: "application/json",
    gutters: ["CodeMirror-linenumbers", "CodeMirror-foldgutter"],
    lint: true,
     theme: "monokai",
    autoCloseBrackets: true,
    matchBrackets: true,
    autocomplete: true,
    highlightSelectionMatches: { showToken: /\w/, annotateScrollbar: true },
    foldGutter: true,

});
editor.setOption("fold", "brace");