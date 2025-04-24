// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiInboxOut : ComponentBase
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
		builder.AddAttribute(14, "id", "Inbox_Out");
		builder.AddAttribute(15, "data-name", "Inbox Out");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.488,19.944H3.512a1.452,1.452,0,0,1-1.45-1.45V12.856a1.452,1.452,0,0,1,1.45-1.45h4.1a1.442,1.442,0,0,1,1.3.8l1.373,2.725a.449.449,0,0,0,.4.247h2.629a.448.448,0,0,0,.4-.248L15.09,12.2a1.442,1.442,0,0,1,1.3-.8h4.1a1.452,1.452,0,0,1,1.45,1.45v5.638A1.452,1.452,0,0,1,20.488,19.944ZM3.512,12.406a.451.451,0,0,0-.45.45v5.638a.45.45,0,0,0,.45.45H20.488a.45.45,0,0,0,.45-.45V12.856a.451.451,0,0,0-.45-.45h-4.1a.449.449,0,0,0-.4.247L14.61,15.378a1.445,1.445,0,0,1-1.295.8H10.686a1.444,1.444,0,0,1-1.295-.8L8.018,12.653a.449.449,0,0,0-.4-.247Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12.5,5.753v4.83a.5.5,0,0,1-1,0V5.763l-1.27,1.27a.524.524,0,0,1-.71,0,.513.513,0,0,1,0-.71l2.13-2.12a.492.492,0,0,1,.7,0l2.12,2.12a.5.5,0,0,1,0,.71.511.511,0,0,1-.7,0Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
