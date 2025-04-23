// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiEmotionSadFill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12 2C17.5228 2 22 6.47715 22 12C22 13.6169 21.6162 15.1442 20.9348 16.4958C20.8633 16.2175 20.7307 15.9523 20.5374 15.7206L20.4142 15.5858L19 14.1716L17.5858 15.5858L17.469 15.713C16.8069 16.4988 16.8458 17.6743 17.5858 18.4142C18.014 18.8424 18.588 19.0358 19.148 18.9946C17.3323 20.8487 14.8006 22 12 22C6.47715 22 2 17.5228 2 12C2 6.47715 6.47715 2 12 2ZM12 15C10.6199 15 9.37036 15.5592 8.46564 16.4633L8.30009 16.6368L9.24506 17.4961C10.035 17.1825 10.982 17 12 17C12.9049 17 13.7537 17.1442 14.4859 17.3965L14.7549 17.4961L15.6999 16.6368C14.7853 15.6312 13.4664 15 12 15ZM8.5 10C7.67157 10 7 10.6716 7 11.5C7 12.3284 7.67157 13 8.5 13C9.32843 13 10 12.3284 10 11.5C10 10.6716 9.32843 10 8.5 10ZM15.5 10C14.6716 10 14 10.6716 14 11.5C14 12.3284 14.6716 13 15.5 13C16.3284 13 17 12.3284 17 11.5C17 10.6716 16.3284 10 15.5 10Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
