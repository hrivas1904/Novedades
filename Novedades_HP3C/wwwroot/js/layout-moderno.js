document.addEventListener("DOMContentLoaded", function () {

    const btn = document.getElementById("btnToggleSidebar");
    const sidebar = document.getElementById("sidebarVertical");

    if (!btn || !sidebar) return;

    btn.addEventListener("click", function () {
        sidebar.classList.toggle("collapsed");
        sidebar.classList.toggle("show");
    });

});
