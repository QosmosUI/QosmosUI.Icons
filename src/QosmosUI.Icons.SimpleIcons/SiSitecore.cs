// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSitecore : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 0C5.37 0 0 5.37 0 12s5.37 12 12 12 12-5.37 12-12S18.63 0 12 0Zm0 3.266A8.714 8.714 0 0 1 20.734 12c0 4.815-3.92 8.734-8.734 8.734A8.73 8.73 0 0 1 3.266 12 8.73 8.73 0 0 1 12 3.266Zm6.701 3.847-2.878 1.839c.87 1.379.991 2.879.314 4.403-.774 1.838-2.613 3.41-4.694 4.16a7.337 7.337 0 0 0 2.662-.87c2.032-1.137 3.194-3.073 3.29-5.468v-.218h2.83c-.168-1.427-.725-2.734-1.524-3.846Zm-.87 4.282c-.17 2.42-1.428 4.476-3.508 5.613a8.13 8.13 0 0 1-3.92.992 9.19 9.19 0 0 1-3.194-.58c1.259.774 2.662 1.21 4.113 1.21h.025c2.613 0 4.984-1.38 6.314-3.727l.121-.193 1.621 1.04A8.166 8.166 0 0 0 20.3 12c0-.194-.025-.387-.025-.605zm.072 3.943c-1.427 2.323-3.846 3.726-6.556 3.726-2.637 0-5.105-1.306-6.847-3.532 1.33 2.807 4.185 4.766 7.5 4.766a8.267 8.267 0 0 0 7.185-4.161z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
