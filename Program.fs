let update (msg: SubpageMsg) (model: NavigationModel) =
    let subpageModel, cmdMsgs =
        match msg, model.CurrentPage with
        | AcrylicPageMsg subMsg, AcrylicPageModel m ->
            let m, c = AcrylicPage.update subMsg m
            AcrylicPageModel m, [ AcrylicPageCmdMsgs c ]

        | AdornerLayerPageMsg subMsg, AdornerLayerPageModel m ->
            let m, c = AdornerLayerPage.update subMsg m
            AdornerLayerPageModel m, [ AdornerLayerPageCmdMsgs c ]

        | AutoCompleteBoxPageMsg subMsg, AutoCompleteBoxPageModel m ->
            let m, c = AutoCompleteBoxPage.update subMsg m
            AutoCompleteBoxPageModel m, [ AutoCompleteBoxPageCmdMsgs c ]

        | AnimationsPageMsg subMsg, AnimationsPageModel m ->
            let m, c = AnimationsPage.update subMsg m
            AnimationsPageModel m, [ AnimationsPageCmdMsgs c ]

        | ImplicitCanvasAnimationsPageMsg subMsg, ImplicitCanvasAnimationsPageModel m ->
            let m, c = ImplicitCanvasAnimationsPage.update subMsg m
            ImplicitCanvasAnimationsPageModel m, [ ImplicitCanvasAnimationsPageCmdMsgs c ]

        | CompositorAnimationsPageMsg subMsg, CompositorAnimationsPageModel m ->
            let m, c = CompositorAnimationsPage.update subMsg m
            CompositorAnimationsPageModel m, [ CompositorAnimationsPageCmdMsgs c ]

        | ButtonsPageMsg subMsg, ButtonsPageModel m ->
            let m, c = ButtonsPage.update subMsg m
            ButtonsPageModel m, [ ButtonsPageCmdMsgs c ]

        | BrushesPageMsg subMsg, BrushesPageModel m ->
            let m, c = BrushesPage.update subMsg m
            BrushesPageModel m, [ BrushesPageCmdMsgs c ]

        | ButtonSpinnerPageMsg subMsg, ButtonSpinnerPageModel m ->
            let m, c = ButtonSpinnerPage.update subMsg m
            ButtonSpinnerPageModel m, [ ButtonSpinnerPageCmdMsgs c ]

        | BorderPageMsg subMsg, BorderPageModel m ->
            let m, c = BorderPage.update subMsg m
            BorderPageModel m, [ BorderPageCmdMsgs c ]

        | CheckBoxPageMsg subMsg, CheckBoxPageModel m ->
            let m, c = CheckBoxPage.update subMsg m
            CheckBoxPageModel m, [ CheckBoxPageCmdMsgs c ]

        | CalendarDatePickerPageMsg subMsg, CalendarDatePickerPageModel m ->
            let m, c = CalendarDatePickerPage.update subMsg m
            CalendarDatePickerPageModel m, [ CalendarDatePickerPageCmdMsgs c ]

        | CalendarPageMsg subMsg, CalendarPageModel m ->
            let m, c = CalendarPage.update subMsg m
            CalendarPageModel m, [ CalendarPageCmdMsgs c ]

        | CanvasPageMsg subMsg, CanvasPageModel m ->
            let m, c = CanvasPage.update subMsg m
            CanvasPageModel m, [ CanvasPageCmdMsgs c ]

        | CarouselPageMsg subMsg, CarouselPageModel m ->
            let m, c = CarouselPage.update subMsg m
            CarouselPageModel m, [ CarouselPageCmdMsgs c ]

        | ClippingPageMsg subMsg, ClippingPageModel m ->
            let m, c = ClippingPage.update subMsg m
            ClippingPageModel m, [ ClippingPageCmdMsgs c ]

        | ClipboardPageMsg subMsg, ClipboardPageModel m ->
            let m, c = ClipboardPage.update subMsg m
            ClipboardPageModel m, [ ClipboardPageCmdMsgs c ]

        | ComboBoxPageMsg subMsg, ComboBoxPageModel m ->
            let m, c = ComboBoxPage.update subMsg m
            ComboBoxPageModel m, [ ComboBoxPageCmdMsgs c ]

        | CompositionPageMsg subMsg, CompositionPageModel m ->
            let m, c = CompositionPage.update subMsg m
            CompositionPageModel m, [ CompositionPageCmdMsgs c ]

        | ContextFlyoutPageMsg subMsg, ContextFlyoutPageModel m ->
            let m, c = ContextFlyoutPage.update subMsg m
            ContextFlyoutPageModel m, [ ContextFlyoutPageCmdMsgs c ]

        | ContextMenuPageMsg subMsg, ContextMenuPageModel m ->
            let m, c = ContextMenuPage.update subMsg m
            ContextMenuPageModel m, [ ContextMenuPageCmdMsgs c ]

        | DockPanelPageMsg subMsg, DockPanelPageModel m ->
            let m, c = DockPanelPage.update subMsg m
            DockPanelPageModel m, [ DockPanelPageCmdMsgs c ]

        | DialogsPageMsg subMsg, DialogsPageModel m ->
            let m, c = DialogsPage.update subMsg m
            DialogsPageModel m, [ DialogsPageCmdMsgs c ]
        | DragAndDropPageMsg subMsg, DragAndDropPageModel m ->
            let m, c = DragAndDropPage.update subMsg m
            DragAndDropPageModel m, [ DragAndDropPageCmdMsgs c ]

        | DropDownButtonPageMsg subMsg, DropDownButtonPageModel m ->
            let m, c = DropDownButtonPage.update subMsg m
            DropDownButtonPageModel m, [ DropDownButtonPageCmdMsgs c ]

        | DrawLineAnimationPageMsg subMsg, DrawLineAnimationPageModel m ->
            let m, c = DrawLineAnimationPage.update subMsg m
            DrawLineAnimationPageModel m, [ DrawLineAnimationPageCmdMsgs c ]

        | DrawingPageMsg subMsg, DrawingPageModel m ->
            let m, c = DrawingPage.update subMsg m
            DrawingPageModel m, [ DrawingPageCmdMsgs c ]

        | EffectsPageMsg subMsg, EffectsPageModel m ->
            let m, c = EffectsPage.update subMsg m
            EffectsPageModel m, [ EffectsPageCmdMsgs c ]

        | ExpanderPageMsg subMsg, ExpanderPageModel m ->
            let m, c = ExpanderPage.update subMsg m
            ExpanderPageModel m, [ ExpanderPageCmdMsgs c ]

        | FlyoutPageMsg subMsg, FlyoutPageModel m ->
            let m, c = FlyoutPage.update subMsg m
            FlyoutPageModel m, [ FlyoutPageCmdMsgs c ]

        | GesturesPageMsg subMsg, GesturesPageModel m ->
            let m, c = GesturesPage.update subMsg m
            GesturesPageModel m, [ GesturesPageCmdMsgs c ]

        | GeometriesPageMsg subMsg, GeometriesPageModel m ->
            let m, c = GeometriesPage.update subMsg m
            GeometriesPageModel m, [ GeometriesPageCmdMsgs c ]

        | GridPageMsg subMsg, GridPageModel m ->
            let m, c = GridPage.update subMsg m
            GridPageModel m, [ GridPageCmdMsgs c ]

        | GridSplitterPageMsg subMsg, GridSplitterPageModel m ->
            let m, c = GridSplitterPage.update subMsg m
            GridSplitterPageModel m, [ GridSplitterPageCmdMsgs c ]

        | ImagePageMsg subMsg, ImagePageModel m ->
            let m, c = ImagePage.update subMsg m
            ImagePageModel m, [ ImagePageCmdMsgs c ]

        | LabelPageMsg subMsg, LabelPageModel m ->
            let m, c = LabelPage.update subMsg m
            LabelPageModel m, [ LabelPageCmdMsgs c ]

        | LayoutTransformControlPageMsg subMsg, LayoutTransformControlPageModel m ->
            let m, c = LayoutTransformControlPage.update subMsg m
            LayoutTransformControlPageModel m, [ LayoutTransformControlPageCmdMsgs c ]

        | LineBoundsDemoControlPageMsg subMsg, LineBoundsDemoControlPageModel m ->
            let m, c = LineBoundsDemoControlPage.update subMsg m
            LineBoundsDemoControlPageModel m, [ LineBoundsDemoControlPageCmdMsgs c ]

        | ListBoxPageMsg subMsg, ListBoxPageModel m ->
            let m, c = ListBoxPage.update subMsg m
            ListBoxPageModel m, [ ListBoxPageCmdMsgs c ]

        | MaskedTextBoxPageMsg subMsg, MaskedTextBoxPageModel m ->
            let m, c = MaskedTextBoxPage.update subMsg m
            MaskedTextBoxPageModel m, [ MaskedTextBoxPageCmdMsgs c ]

        | MenuPageMsg subMsg, MenuPageModel m ->
            let m, c = MenuPage.update subMsg m
            MenuPageModel m, [ MenuPageCmdMsgs c ]

        | MenuFlyoutPageMsg subMsg, MenuFlyoutPageModel m ->
            let m, c = MenuFlyoutPage.update subMsg m
            MenuFlyoutPageModel m, [ MenuFlyoutPageCmdMsgs c ]

        | NumericUpDownPageMsg subMsg, NumericUpDownPageModel m ->
            let m, c = NumericUpDownPage.update subMsg m
            NumericUpDownPageModel m, [ NumericUpDownPageCmdMsgs c ]

        | NotificationsPageMsg subMsg, NotificationsPageModel m ->
            let m, c = NotificationsPage.update subMsg m
            NotificationsPageModel m, [ NotificationsPageCmdMsgs c ]

        | OpenGLPageMsg subMsg, OpenGLPageModel m ->
            let m, c = OpenGLPage.update subMsg m
            OpenGLPageModel m, [ OpenGLPageCmdMsgs c ]

        | PanelPageMsg subMsg, PanelPageModel m ->
            let m, c = PanelPage.update subMsg m
            PanelPageModel m, [ PanelPageCmdMsgs c ]

        | PathIconPageMsg subMsg, PathIconPageModel m ->
            let m, c = PathIconPage.update subMsg m
            PathIconPageModel m, [ PathIconPageCmdMsgs c ]

        | PageTransitionsPageMsg subMsg, PageTransitionsPageModel m ->
            let m, c = PageTransitionsPage.update subMsg m
            PageTransitionsPageModel m, [ PageTransitionsPageCmdMsgs c ]

        | PointersPageMsg subMsg, PointersPageModel m ->
            let m, c = PointersPage.update subMsg m
            PointersPageModel m, [ PointersPageCmdMsgs c ]

        | PopupPageMsg subMsg, PopupPageModel m ->
            let m, c = PopupPage.update subMsg m
            PopupPageModel m, [ PopupPageCmdMsgs c ]

        | ProgressBarPageMsg subMsg, ProgressBarPageModel m ->
            let m, c = ProgressBarPage.update subMsg m
            ProgressBarPageModel m, [ ProgressBarPageCmdMsgs c ]

        | RadioButtonPageMsg subMsg, RadioButtonPageModel m ->
            let m, c = RadioButtonPage.update subMsg m
            RadioButtonPageModel m, [ RadioButtonPageCmdMsgs c ]

        | RefreshContainerPageMsg subMsg, RefreshContainerPageModel m ->
            let m, c = RefreshContainerPage.update subMsg m
            RefreshContainerPageModel m, [ RefreshContainerPageCmdMsgs c ]

        | RepeatButtonPageMsg subMsg, RepeatButtonPageModel m ->
            let m, c = RepeatButtonPage.update subMsg m
            RepeatButtonPageModel m, [ RepeatButtonPageCmdMsgs c ]

        | ScrollBarPageMsg subMsg, ScrollBarPageModel m ->
            let m, c = ScrollBarPage.update subMsg m
            ScrollBarPageModel m, [ ScrollBarPageCmdMsgs c ]

        | ScrollViewerPageMsg subMsg, ScrollViewerPageModel m ->
            let m, c = ScrollViewerPage.update subMsg m
            ScrollViewerPageModel m, [ ScrollViewerPageCmdMsgs c ]

        | SelectableTextBlockPageMsg subMsg, SelectableTextBlockPageModel m ->
            let m, c = SelectableTextBlockPage.update subMsg m
            SelectableTextBlockPageModel m, [ SelectableTextBlockPageCmdMsgs c ]

        | SliderPageMsg subMsg, SliderPageModel m ->
            let m, c = SliderPage.update subMsg m
            SliderPageModel m, [ SliderPageCmdMsgs c ]

        | SplitButtonPageMsg subMsg, SplitButtonPageModel m ->
            let m, c = SplitButtonPage.update subMsg m
            SplitButtonPageModel m, [ SplitButtonPageCmdMsgs c ]

        | SplitViewPageMsg subMsg, SplitViewPageModel m ->
            let m, c = SplitViewPage.update subMsg m
            SplitViewPageModel m, [ SplitViewPageCmdMsgs c ]

        | StackPanelPageMsg subMsg, StackPanelPageModel m ->
            let m, c = StackPanelPage.update subMsg m
            StackPanelPageModel m, [ StackPanelPageCmdMsgs c ]

        | StylesPageMsg subMsg, StylesPageModel m ->
            let m, c = StylesPage.update subMsg m
            StylesPageModel m, [ StylesPageCmdMsgs c ]

        | TabStripPageMsg subMsg, TabStripPageModel m ->
            let m, c = TabStripPage.update subMsg m
            TabStripPageModel m, [ TabStripPageCmdMsgs c ]

        | TabControlPageMsg subMsg, TabControlPageModel m ->
            let m, c = TabControlPage.update subMsg m
            TabControlPageModel m, [ TabControlPageCmdMsgs c ]

        | TextBoxPageMsg subMsg, TextBoxPageModel m ->
            let m, c = TextBoxPage.update subMsg m
            TextBoxPageModel m, [ TextBoxPageCmdMsgs c ]

        | TextBlockPageMsg subMsg, TextBlockPageModel m ->
            let m, c = TextBlockPage.update subMsg m
            TextBlockPageModel m, [ TextBlockPageCmdMsgs c ]

        | TickBarPageMsg subMsg, TickBarPageModel m ->
            let m, c = TickBarPage.update subMsg m
            TickBarPageModel m, [ TickBarPageCmdMsgs c ]

        | ToggleButtonPageMsg subMsg, ToggleButtonPageModel m ->
            let m, c = ToggleButtonPage.update subMsg m
            ToggleButtonPageModel m, [ ToggleButtonPageCmdMsgs c ]

        | ToggleSwitchPageMsg subMsg, ToggleSwitchPageModel m ->
            let m, c = ToggleSwitchPage.update subMsg m
            ToggleSwitchPageModel m, [ ToggleSwitchPageCmdMsgs c ]

        | ToggleSplitButtonPageMsg subMsg, ToggleSplitButtonPageModel m ->
            let m, c = ToggleSplitButtonPage.update subMsg m
            ToggleSplitButtonPageModel m, [ ToggleSplitButtonPageCmdMsgs c ]

        | TransitionsPageMsg subMsg, TransitionsPageModel m ->
            let m, c = TransitionsPage.update subMsg m
            TransitionsPageModel m, [ TransitionsPageCmdMsgs c ]

        | ThemeAwarePageMsg subMsg, ThemeAwarePageModel m ->
            let m, c = ThemeAwarePage.update subMsg m
            ThemeAwarePageModel m, [ ThemeAwarePageCmdMsgs c ]

        | ToolTipPageMsg subMsg, ToolTipPageModel m ->
            let m, c = ToolTipPage.update subMsg m
            ToolTipPageModel m, [ ToolTipPageCmdMsgs c ]

        | TransformsPageMsg subMsg, TransformsPageModel m ->
            let m, c = TransformsPage.update subMsg m
            TransformsPageModel m, [ TransformsPageCmdMsgs c ]

        | UniformGridPageMsg subMsg, UniformGridPageModel m ->
            let m, c = UniformGridPage.update subMsg m
            UniformGridPageModel m, [ UniformGridPageCmdMsgs c ]

        | ShapesPageMsg subMsg, ShapesPageModel m ->
            let m, c = ShapesPage.update subMsg m
            ShapesPageModel m, [ ShapesPageCmdMsgs c ]

        | ViewBoxPageMsg subMsg, ViewBoxPageModel m ->
            let m, c = ViewBoxPage.update subMsg m
            ViewBoxPageModel m, [ ViewBoxPageCmdMsgs c ]