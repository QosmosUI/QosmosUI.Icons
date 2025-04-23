// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiArlo : ComponentBase
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
		builder.AddAttribute(15, "d", "m16.21 11.172 4.963-5.792c.943-1.293 1.494-1.828 1.07-3.94l-7.367 8.6a7.907 7.907 0 0 0-1.896 5.487L9.763 11.87a5.775 5.775 0 0 0-.947-.829A9.979 9.979 0 0 0 7 10.051c.213-.076.43-.14.649-.194.385-.094.78-.144 1.176-.147.444 0 .881.07 1.3.237.416.168.82.432 1.212.858l.216.252 1.336-1.129c-.01-.011-.241-.283-.251-.292a5.09 5.09 0 0 0-1.86-1.308 5.233 5.233 0 0 0-1.953-.364c-.151 0-.299.007-.446.017-1.461.24-2.364 1.104-3.714 1.244.001.006-4.58 0-4.581.002-.101 0-.115.144-.017.163 1.202.24 3.341.699 4.844 1.214 1.142.529 2.24 1.205 3.106 2.022.17.135.317.271.439.405l4.283 4.87c.61.501 1.395.755 3.066.767a6.197 6.197 0 0 1-.695-1.337 6.173 6.173 0 0 1-.014-4.256 6.139 6.139 0 0 1 1.114-1.903zM24 22.56c-1.734-.022-2.489-.317-3.11-.888l-.962-1.093c-.065-.079-.13-.157-.197-.234l.011.023-1.704-1.937a4.794 4.794 0 0 1-.905-4.806 4.755 4.755 0 0 1 .871-1.482l4.208-4.892c.43 2.179-.192 2.666-1.21 4.09l-1.668 1.937a3.038 3.038 0 0 0-.739 1.989c.001.741.272 1.458.761 2.014L24 22.56z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
