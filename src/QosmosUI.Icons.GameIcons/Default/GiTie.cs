// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTie : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M225.124 33.908c-1 0-3.118.68-5.855 3.05-2.74 2.373-5.792 6.186-8.43 10.58-5.273 8.79-8.716 20.37-8.716 25.37s3.68 21.406 9.272 34.455c2.796 6.525 6.08 12.466 9.042 16.22 2.964 3.753 5.186 4.325 4.686 4.325h64c-.5 0 1.722-.572 4.686-4.326 2.963-3.753 6.246-9.694 9.043-16.22 5.592-13.048 9.27-29.454 9.27-34.454s-3.442-16.58-8.716-25.37c-2.637-4.394-5.69-8.207-8.428-10.58-2.738-2.37-4.856-3.05-5.856-3.05h-64zm7.22 112l-8.452 38.03 62.966-15.74-4.953-22.29h-49.562zm58.42 39.867l-71.238 17.81-10.693 48.12 91.5-22.875-9.568-43.055zm13.473 60.63l-99.77 24.945-10.693 48.12 120.032-30.01-9.57-43.054zm13.475 60.632L189.41 339.113l-10.694 48.12 148.564-37.14-9.568-43.056zm13.473 60.633L174.35 406.88l-3.103 13.96 35.193 23.463 134.313-33.578-9.568-43.055zm-7.084 65.77l-97.42 24.355 30.444 20.297 66.977-44.65z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
