// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiRoute : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Route");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M21.792,17.086c-.58-.58-1.16-1.17-1.75-1.75-.08-.08-.16-.17-.25-.25a.492.492,0,0,0-.7,0,.5.5,0,0,0,0,.71l1.14,1.14H9.282a2.22,2.22,0,0,1,0-4.44h3a3.215,3.215,0,1,0,0-6.43H7.012a2.5,2.5,0,1,0,0,1h5.27a2.215,2.215,0,1,1,0,4.43h-3a3.22,3.22,0,1,0,0,6.44h10.96l-.9.9c-.09.08-.17.17-.25.25a.5.5,0,0,0,0,.71.511.511,0,0,0,.7,0l1.75-1.75.25-.25A.5.5,0,0,0,21.792,17.086ZM4.562,8.066a1.5,1.5,0,1,1,1.5-1.5A1.5,1.5,0,0,1,4.562,8.066Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
