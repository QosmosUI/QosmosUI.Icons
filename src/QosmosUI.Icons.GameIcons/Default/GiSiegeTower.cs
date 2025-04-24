// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSiegeTower : ComponentBase
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
		builder.AddAttribute(14, "d", "M137 41v78h190V41h-30v48h-18V73h-14v16h-18V41h-30v48h-18V73h-14v16h-18V41h-30zm208 19.273v25.454L394.273 135H329v18H457v-18H419.727L345 60.273zM173.977 137l20.91 46h79.445l29.272-46H173.977zm-10.268 20.912L159.147 183h15.965l-11.404-25.088zm147.29.996L295.668 183H311v-24.092zM155.875 201l-8.363 46h56.693l-20.91-46h-27.42zm47.193 0l20.91 46h9.626l29.273-46h-59.81zm81.145 0l-29.272 46H311v-46h-26.787zM144.24 265l-8.365 46h57.002l23.578-37.05-4.068-8.95H144.24zm99.246 0l-6.607 10.383L253.067 311H311v-46h-67.514zm-18.14 28.508L214.216 311h19.08l-7.95-17.492zM132.604 329l-8.364 46h27.908l29.274-46h-48.818zm70.156 0l-29.274 46h88.9l-20.907-46h-38.72zm58.49 0l20.908 46H311v-46h-49.75zm-140.283 64l-6.28 34.553c1.007.52 1.993 1.08 2.952 1.68L140.694 393h-19.728zm41.066 0l-31.34 49.248C134.68 448.565 137 456.025 137 464c0 2.386-.218 4.722-.615 7h23.392c-.396-2.278-.615-4.614-.615-7 0-22.537 18.463-41 41-41s41 18.463 41 41c0 2.386-.218 4.722-.615 7h23.068c-.397-2.278-.615-4.614-.615-7 0-16.127 9.456-30.165 23.092-36.848L270.568 393H162.033zm128.31 0l13.636 30h.02c2.386 0 4.722.218 7 .615V393h-20.658zM96 441c-12.81 0-23 10.19-23 23s10.19 23 23 23 23-10.19 23-23-10.19-23-23-23zm104.162 0c-12.81 0-23 10.19-23 23s10.19 23 23 23 23-10.19 23-23-10.19-23-23-23zM304 441c-12.81 0-23 10.19-23 23s10.19 23 23 23 23-10.19 23-23-10.19-23-23-23z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
