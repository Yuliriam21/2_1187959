using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AplicacionesMenu
{
    public partial class Form1 : Form
    {
        FontStyle negrita = FontStyle.Regular;
        FontStyle subrayado = FontStyle.Regular;
        FontStyle italica = FontStyle.Regular;
        FontStyle tachado = FontStyle.Regular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem gToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem mayusculasToolStripMenuItem;
        private ToolStripMenuItem minusculasToolStripMenuItem;
        private ToolStripMenuItem longitudToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem1;
        private ToolStripMenuItem negritasToolStripMenuItem;
        private ToolStripMenuItem italicasToolStripMenuItem;
        private ToolStripMenuItem subrayadasToolStripMenuItem;
        private ToolStripMenuItem tachadoToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem alineacionToolStripMenuItem;
        private ToolStripMenuItem derechaToolStripMenuItem;
        private ToolStripMenuItem izquierdaToolStripMenuItem;
        private ToolStripMenuItem centradoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        private ToolStripButton toolStripButton13;
        private ToolStripButton toolStripButton14;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox2;
        private ToolStripMenuItem abrirToolStripMenuItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.negritasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subrayadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alineacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.gToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.nuevo;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +N";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.ToolTipText = "crear nuevo archivo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.abrir;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +A";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.ToolTipText = "abrir archivo";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.guardar;
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +G";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gToolStripMenuItem.Text = "Guardar";
            this.gToolStripMenuItem.ToolTipText = "guardar archivo";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.png_clipart_check_mark_x_mark_computer_icons_cross_heart_angle_desktop_wallpaper_removebg_preview;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem,
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.ToolTipText = "copiar cadena";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.copiar;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +C";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.pegar;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +V";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.ToolTipText = "pegar cadena";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.cortar;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +X";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.ToolTipText = "cortar cadena";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.seleccionarTodo;
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +E";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.ToolTipText = "seleccionar todo lo del archivo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.deshacer;
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +Z";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.deshacerToolStripMenuItem.ToolTipText = "regresar anterior";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.rehacer;
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +Y";
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.rehacerToolStripMenuItem.Text = "Rehacer";
            this.rehacerToolStripMenuItem.ToolTipText = "regresar de nuevo";
            this.rehacerToolStripMenuItem.Click += new System.EventHandler(this.rehacerToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.limpiar;
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +L";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.ToolTipText = "borrar todo";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayusculasToolStripMenuItem,
            this.minusculasToolStripMenuItem,
            this.longitudToolStripMenuItem,
            this.formatoToolStripMenuItem1,
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.alineacionToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // mayusculasToolStripMenuItem
            // 
            this.mayusculasToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.mayusculas;
            this.mayusculasToolStripMenuItem.Name = "mayusculasToolStripMenuItem";
            this.mayusculasToolStripMenuItem.ShortcutKeyDisplayString = "Alt +Y";
            this.mayusculasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mayusculasToolStripMenuItem.Text = "Mayusculas";
            this.mayusculasToolStripMenuItem.ToolTipText = "cadena de mayusculas";
            this.mayusculasToolStripMenuItem.Click += new System.EventHandler(this.mayusculasToolStripMenuItem_Click);
            // 
            // minusculasToolStripMenuItem
            // 
            this.minusculasToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.text_case_lowercase_regular_icon_203191;
            this.minusculasToolStripMenuItem.Name = "minusculasToolStripMenuItem";
            this.minusculasToolStripMenuItem.ShortcutKeyDisplayString = "Alt +M";
            this.minusculasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minusculasToolStripMenuItem.Text = "Minusculas";
            this.minusculasToolStripMenuItem.ToolTipText = "cadena en minusculas";
            this.minusculasToolStripMenuItem.Click += new System.EventHandler(this.minusculasToolStripMenuItem_Click);
            // 
            // longitudToolStripMenuItem
            // 
            this.longitudToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.length_5360;
            this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
            this.longitudToolStripMenuItem.ShortcutKeyDisplayString = "Alt +L";
            this.longitudToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.longitudToolStripMenuItem.Text = "Longitud";
            this.longitudToolStripMenuItem.ToolTipText = "longitud de cadena";
            // 
            // formatoToolStripMenuItem1
            // 
            this.formatoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritasToolStripMenuItem,
            this.italicasToolStripMenuItem,
            this.subrayadasToolStripMenuItem,
            this.tachadoToolStripMenuItem});
            this.formatoToolStripMenuItem1.Image = global::AplicacionesMenu.Properties.Resources.document_file_format_page_paper_sheet_text_icon_123202;
            this.formatoToolStripMenuItem1.Name = "formatoToolStripMenuItem1";
            this.formatoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.formatoToolStripMenuItem1.Text = "Formato";
            this.formatoToolStripMenuItem1.ToolTipText = "escoger el formato";
            // 
            // negritasToolStripMenuItem
            // 
            this.negritasToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources._format_bold_90061;
            this.negritasToolStripMenuItem.Name = "negritasToolStripMenuItem";
            this.negritasToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +B";
            this.negritasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.negritasToolStripMenuItem.Text = "Negritas";
            this.negritasToolStripMenuItem.Click += new System.EventHandler(this.negritasToolStripMenuItem_Click);
            // 
            // italicasToolStripMenuItem
            // 
            this.italicasToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.italica_removebg_preview;
            this.italicasToolStripMenuItem.Name = "italicasToolStripMenuItem";
            this.italicasToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +I";
            this.italicasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.italicasToolStripMenuItem.Text = "Italicas";
            this.italicasToolStripMenuItem.Click += new System.EventHandler(this.italicasToolStripMenuItem_Click);
            // 
            // subrayadasToolStripMenuItem
            // 
            this.subrayadasToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources._format_underlined_89960;
            this.subrayadasToolStripMenuItem.Name = "subrayadasToolStripMenuItem";
            this.subrayadasToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +U";
            this.subrayadasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.subrayadasToolStripMenuItem.Text = "Subrayadas";
            this.subrayadasToolStripMenuItem.Click += new System.EventHandler(this.subrayadasToolStripMenuItem_Click);
            // 
            // tachadoToolStripMenuItem
            // 
            this.tachadoToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.png_transparent_strikethrough_computer_icons_encapsulated_postscript_strikethrough_text_logo_number_removebg_preview;
            this.tachadoToolStripMenuItem.Name = "tachadoToolStripMenuItem";
            this.tachadoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +T";
            this.tachadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tachadoToolStripMenuItem.Text = "Tachado";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.RGB_Circle_1_80_icon_icons_com_57282;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeyDisplayString = " Alt +C";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.font_symbol_of_letter_a_icon_icons_com_73556;
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.ShortcutKeyDisplayString = "Alt +A";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // alineacionToolStripMenuItem
            // 
            this.alineacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derechaToolStripMenuItem,
            this.izquierdaToolStripMenuItem,
            this.centradoToolStripMenuItem});
            this.alineacionToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources._1486486283_align_justify_text_text_align_text_control_81214;
            this.alineacionToolStripMenuItem.Name = "alineacionToolStripMenuItem";
            this.alineacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alineacionToolStripMenuItem.Text = "Alineacion";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources.derecha_removebg_preview;
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.derechaToolStripMenuItem.Text = "Derecha";
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Image = global::AplicacionesMenu.Properties.Resources._174071;
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            // 
            // centradoToolStripMenuItem
            // 
            this.centradoToolStripMenuItem.Name = "centradoToolStripMenuItem";
            this.centradoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.centradoToolStripMenuItem.Text = "Centrado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "abrir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "guardar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "salir";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "copiar";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "pegar";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "cortar";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "seleccionarTodo";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton9.Text = "rehacer";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton10.Text = "deshacer";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton11.Text = "limpiar";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton12.Text = "negritas";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton13.Text = "italica";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton14.Text = "subrayado";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 58);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(848, 513);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(860, 583);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        string archivo;
        private object txt;

        private void Nuevo()
        {
            richTextBox2.Clear();
        }

        private void AbrirArchivo()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox2.Text = sr.ReadToEnd();
                }
            }
        }

        private void GuardarArchivo()
        {

            SaveFileDialog saveFile = new SaveFileDialog { Filter = "Texto|*.txt" };
            if (!string.IsNullOrEmpty(archivo))
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox2.Text);
                    MessageBox.Show($"Archivo guardado en: {archivo}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (saveFile.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFile.FileName;
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.Write(richTextBox2.Text);
                    MessageBox.Show($"Archivo guardado en: {archivo}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Salir()
        {
            this.Dispose();
        }

        private void Copiar()
        {
            if (richTextBox2.SelectedText != "")
                Clipboard.SetDataObject(richTextBox2.SelectedText);
        }

        private void Pegar()
        {
            IDataObject iData = Clipboard.GetDataObject();
            richTextBox2.Text = (string)iData.GetData(DataFormats.Text);
        }

        private void Cortar()
        {
            if (richTextBox2.SelectedText != "")
                richTextBox2.Cut();
        }

        private void SeleccionarTodo()
        {
            richTextBox2.SelectionStart = 0;
            richTextBox2.SelectionLength = richTextBox2.Text.Length;
        }

        private void Rehacer()
        {
            if (richTextBox2.CanRedo)
                richTextBox2.Redo();
        }

        private void Deshacer()
        {
            if (richTextBox2.CanUndo)
                richTextBox2.Undo();
        }

        private void Limpiar()
        {
            richTextBox2.Clear();
        }

        private void Negritas()
        {
            if (negrita == FontStyle.Bold)
            { // Negrita a regular
                negrita = FontStyle.Regular;
            }
            else
            { // Regular a negrita
                negrita = FontStyle.Bold;
            }
            richTextBox2.Font = new Font(richTextBox2.Font, negrita | subrayado | italica | tachado);
        }

        private void Italica()
        {
            if (richTextBox2.SelectionFont != null)
            {
                FontStyle estilo = richTextBox2.SelectionFont.Style;

                // Alterna el estilo de itálica
                estilo = richTextBox2.SelectionFont.Italic ?
                         estilo & ~FontStyle.Italic :
                         estilo | FontStyle.Italic;

                richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, estilo);
            }
        }

        private void Subrayado()
        {
            if (richTextBox2.SelectionFont != null)
            {
                FontStyle estilo = richTextBox2.SelectionFont.Style;

                // Alterna el estilo de subrayado
                estilo = richTextBox2.SelectionFont.Underline ?
                         estilo & ~FontStyle.Underline :
                         estilo | FontStyle.Underline;

                richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont, estilo);
            }
        }

        private void CambiarColor()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.ForeColor = colorDialog1.Color;
            }
        }

        private void CambiarFuente()
        {
            fontDialog1.Font = richTextBox2.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Font = fontDialog1.Font;
            }
        }

        private void CambiarAMayusculas()
        {
            if (richTextBox2.SelectedText.Length > 0)
                richTextBox2.SelectedText = richTextBox2.SelectedText.ToUpper();
        }

        private void CambiarAMinusculas()
        {
            if (richTextBox2.SelectedText.Length > 0)
                richTextBox2.SelectedText = richTextBox2.SelectedText.ToLower();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pegar();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarTodo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Pegar();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Cortar();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            SeleccionarTodo();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rehacer();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rehacer();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void negritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negritas();
        }

        private void italicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italica();
        }

        private void subrayadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subrayado();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            Italica();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Rehacer();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Rehacer();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarColor();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarFuente();
        }

        private void mayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarAMayusculas();
        }

        private void minusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarAMinusculas();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Negritas();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            Subrayado();
        }
    }
}