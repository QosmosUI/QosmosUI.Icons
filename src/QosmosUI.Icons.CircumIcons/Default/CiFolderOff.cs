// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiFolderOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Folder_Off");
		builder.AddAttribute(15, "data-name", "Folder Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M4.013,3.3a.5.5,0,0,0-.711.71l.25.25A2.438,2.438,0,0,0,2.062,6.5v11a2.453,2.453,0,0,0,2.451,2.44h14.72l.759.76c.461.46,1.171-.25.711-.7Zm.5,15.64A1.45,1.45,0,0,1,3.062,17.5V6.5a1.444,1.444,0,0,1,1.31-1.43C5.893,6.6,7.432,8.14,8.963,9.66q4.485,4.485,8.96,8.97l.31.31Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M21.438,17.693a.5.5,0,0,1-.5-.5V9.175a1.445,1.445,0,0,0-1.445-1.444H12.827a1.5,1.5,0,0,1-1.474-1.225l-.05-.267a1.445,1.445,0,0,0-1.42-1.178H8.8a.5.5,0,0,1,0-1H9.883a2.446,2.446,0,0,1,2.4,1.994l.05.268a.5.5,0,0,0,.491.408h6.666a2.448,2.448,0,0,1,2.445,2.444v8.018A.5.5,0,0,1,21.438,17.693Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
