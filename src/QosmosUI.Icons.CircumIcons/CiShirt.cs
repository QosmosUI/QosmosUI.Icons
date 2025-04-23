// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiShirt : ComponentBase
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
		builder.AddAttribute(14, "id", "Shirt");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M16.657,21.949H7.343a2.5,2.5,0,0,1-2.5-2.5V11.222a6.468,6.468,0,0,1,.112-1.2L5.224,8.59a5.572,5.572,0,0,0,.094-1.015V3.3a1.252,1.252,0,0,1,1.25-1.25H8.815a1.251,1.251,0,0,1,1.25,1.25V6.413a1.935,1.935,0,0,0,3.87,0V3.3a1.251,1.251,0,0,1,1.25-1.25h2.247a1.252,1.252,0,0,1,1.25,1.25V7.575a5.486,5.486,0,0,0,.1,1.015l.269,1.431a6.57,6.57,0,0,1,.111,1.2v8.227A2.5,2.5,0,0,1,16.657,21.949ZM6.568,3.051a.251.251,0,0,0-.25.25V7.575a6.543,6.543,0,0,1-.111,1.2l-.27,1.432a5.5,5.5,0,0,0-.094,1.015v8.227a1.5,1.5,0,0,0,1.5,1.5h9.314a1.5,1.5,0,0,0,1.5-1.5V11.222a5.519,5.519,0,0,0-.094-1.016l-.269-1.43a6.453,6.453,0,0,1-.112-1.2V3.3a.251.251,0,0,0-.25-.25H15.185a.251.251,0,0,0-.25.25V6.413a2.935,2.935,0,0,1-5.87,0V3.3a.251.251,0,0,0-.25-.25Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M11.986,17.333V13.874a.075.075,0,0,0-.114-.064l-.638.392a.149.149,0,0,1-.228-.128v-.65a.3.3,0,0,1,.145-.258l.764-.457a.3.3,0,0,1,.154-.043H12.7a.3.3,0,0,1,.3.3v4.367a.3.3,0,0,1-.3.3h-.409A.3.3,0,0,1,11.986,17.333Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
