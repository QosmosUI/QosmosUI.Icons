// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMedicalClipboard : ComponentBase
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
		builder.AddAttribute(14, "id", "Medical_Clipboard");
		builder.AddAttribute(15, "data-name", "Medical Clipboard");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M17.44,3.5H15.75V2.97a.949.949,0,0,0-1-.91H9.25a.949.949,0,0,0-1,.91V3.5H6.56A2.5,2.5,0,0,0,4.06,6V19.44a2.5,2.5,0,0,0,2.5,2.5H17.44a2.5,2.5,0,0,0,2.5-2.5V6A2.5,2.5,0,0,0,17.44,3.5ZM9.25,3.06l5.5.01V4.19c0,.61-.69,1.12-1.5,1.12h-2.5c-.82,0-1.5-.51-1.5-1.12Zm9.69,16.38a1.511,1.511,0,0,1-1.5,1.5H6.56a1.5,1.5,0,0,1-1.5-1.5V6a1.5,1.5,0,0,1,1.5-1.5H8.28a2.4,2.4,0,0,0,2.47,1.81h2.5A2.4,2.4,0,0,0,15.72,4.5h1.72A1.5,1.5,0,0,1,18.94,6Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.5,12.71a.5.5,0,0,1-.5.5H12.5v1.5a.5.5,0,0,1-.5.5.5.5,0,0,1-.5-.5v-1.5H10a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5h1.5v-1.5a.5.5,0,0,1,.5-.5.508.508,0,0,1,.5.5v1.5H14A.508.508,0,0,1,14.5,12.71Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
